using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Control;

namespace Vendas.Model
{
    public partial class FormVendaProduto : Form
    {
        VendaProduto vendaProduto;
        Usuario usuarioLogado;
        NpgsqlConnection conexao;
        bool inserindo;

        public FormVendaProduto(NpgsqlConnection prConexao, VendaProduto prVendaProduto, Usuario prUsuarioLogado)
        { 
            vendaProduto = prVendaProduto;
            usuarioLogado = prUsuarioLogado;
            conexao = prConexao;
            inserindo = (vendaProduto.Handle == 0);
            InitializeComponent();

            PreencherCampos();
            AtualizarPermissoes();
        }

        private void AtualizarPermissoes()
        {
            int status = VendaDB.GetVendaByHandle(conexao, vendaProduto.Venda).Status;

            BotaoExcluir.Enabled = (status == Status.AgModificacao) ^ (status == Status.Cadastrado);

            BotaoSalvar.Enabled = BotaoExcluir.Enabled;
            TextBoxHandle.ReadOnly = !BotaoExcluir.Enabled;
            TextBoxValorUnitario.ReadOnly = !BotaoExcluir.Enabled;
            TextBoxValorTotal.ReadOnly = !BotaoExcluir.Enabled;
            TextBoxQuantidade.ReadOnly = !BotaoExcluir.Enabled;
            TextBoxObservacao.ReadOnly = !BotaoExcluir.Enabled;
        }

        private void PreencherCampos()
        {
            TextBoxHandle.Text = vendaProduto.Handle.ToString();
            TextBoxValorUnitario.DecimalValue= vendaProduto.ValorUnitario;
            TextBoxValorTotal.DecimalValue = vendaProduto.ValorTotal;
            TextBoxQuantidade.DoubleValue = (double)vendaProduto.Quantidade;
            TextBoxObservacao.Text = vendaProduto.Observacao;

            List<Produto> listaProduto = ProdutoDB.GetProdutos(conexao);
            ComboBoxProduto.DataSource = listaProduto;

            if (!inserindo)
            {
                int indice = 0;
                for (int i = 0; i < listaProduto.Count(); i++)
                {
                    Produto produto = listaProduto[i];
                    if (produto.Handle == vendaProduto.Produto)
                    {
                        indice = i;
                        break;
                    }
                }
                ComboBoxProduto.SelectedIndex = indice;
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (!inserindo)
                {
                    vendaProduto.ValorUnitario = TextBoxValorUnitario.DecimalValue;
                    vendaProduto.ValorTotal = TextBoxValorTotal.DecimalValue;
                    vendaProduto.Quantidade = (decimal)TextBoxQuantidade.DoubleValue;
                    vendaProduto.Observacao = TextBoxObservacao.Text;

                    Produto produto = (Produto)ComboBoxProduto.SelectedItem;
                    vendaProduto.Produto = produto.Handle;

                    VendaProdutoDB.SetAlteraVendaProduto(vendaProduto, conexao);

                    PreencherCampos();
                }
                else
                {
                    vendaProduto.Handle = VendaProdutoDB.GetHandleInsert(conexao);
                    vendaProduto.ValorUnitario = TextBoxValorUnitario.DecimalValue;
                    vendaProduto.ValorTotal = TextBoxValorTotal.DecimalValue;
                    vendaProduto.Quantidade = (decimal)TextBoxQuantidade.DoubleValue;
                    vendaProduto.Observacao = TextBoxObservacao.Text;

                    inserindo = !VendaProdutoDB.SetInsereVendaProduto(vendaProduto, conexao);

                    PreencherCampos();
                }
            }
            else
            {
                MessageBox.Show("Campo obrigatório não preenchido!");
            }

            AtualizarPermissoes();
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja excluir o produto da venda " + vendaProduto.Handle + "?"
                        , "Produto"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                bool retorno = VendaProdutoDB.SetExcluirVendaProduto(vendaProduto.Handle, conexao);
                if (retorno)
                {
                    MessageBox.Show("Sucesso, produto excluído!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro, produto não excluído!");
                }
            }
        }

        private bool VerificarCampos()
        {
            bool Retorno = true;

            if (TextBoxValorUnitario.DecimalValue == 0)
            {
                TextBoxValorUnitario.Focus();
                Retorno = false;
            }

            if (TextBoxValorTotal.DecimalValue == 0)
            {
                TextBoxValorTotal.Focus();
                Retorno = false;
            }

            if (TextBoxQuantidade.DoubleValue == 0)
            {
                TextBoxQuantidade.Focus();
                Retorno = false;
            }

            return Retorno;
        }

        private void ComboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)ComboBoxProduto.SelectedItem;
            vendaProduto.Produto = produto.Handle;

            TextBoxValorUnitario.DecimalValue = produto.Valor;
        }

        private void TextBoxValorUnitario_DecimalValueChanged(object sender, EventArgs e)
        {
            TextBoxValorTotal.DecimalValue = (decimal)TextBoxQuantidade.DoubleValue * TextBoxValorUnitario.DecimalValue;
        }

        private void TextBoxQuantidade_DoubleValueChanged(object sender, EventArgs e)
        {
            TextBoxValorTotal.DecimalValue = (decimal)TextBoxQuantidade.DoubleValue * TextBoxValorUnitario.DecimalValue;
        }

        private void TextBoxValorTotal_DecimalValueChanged(object sender, EventArgs e)
        {
            TextBoxValorUnitario.DecimalValue =  TextBoxValorTotal.DecimalValue / (decimal)TextBoxQuantidade.DoubleValue;
        }
    }
}
