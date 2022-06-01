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
                    produto.Handle = PessoaDB.GetHandleInsert(conexao);
                    produto.Nome = TextBoxNome.Text;
                    produto.Valor = TextBoxValor.DecimalValue;
                    produto.Estoque = (decimal)TextBoxEstoque.DoubleValue;
                    produto.Descricao = TextBoxDescricao.Text;
                    produto.CodigoAuxiliar = TextBoxCodigoAuxiliar.Text;
                    produto.LogDataAlteracao = DateTime.Now;
                    produto.LogUsuarioAlteracao = usuarioLogado.Handle;

                    ProdutoDB.SetAlteraProduto(produto, conexao);

                    PreencherCampos();
                }
                else
                {
                    produto.Handle = PessoaDB.GetHandleInsert(conexao);
                    produto.Nome = TextBoxNome.Text;
                    produto.Valor = TextBoxValor.DecimalValue;
                    produto.Estoque = (decimal)TextBoxEstoque.DoubleValue;
                    produto.Descricao = TextBoxDescricao.Text;
                    produto.CodigoAuxiliar = TextBoxCodigoAuxiliar.Text;
                    produto.LogDataAlteracao = DateTime.Now;
                    produto.LogUsuarioAlteracao = usuarioLogado.Handle;
                    produto.LogDataCadastro = DateTime.Now;
                    produto.LogUsuarioCadastro = usuarioLogado.Handle;

                    inserindo = !ProdutoDB.SetInsereProduto(produto, conexao);

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
                        , $"Deseja excluir o produto " + produto.Nome + "?"
                        , "Produto"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                bool retorno = ProdutoDB.SetExcluirProduto(produto.Handle, conexao);
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

        private void TextBoxCnpjCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool VerificarCampos()
        {
            bool Retorno = true;

            if (TextBoxNome.Text == "")
            {
                TextBoxNome.Focus();
                Retorno = false;
            }

            if (TextBoxValor.DecimalValue == 0)
            {
                TextBoxValor.Focus();
                Retorno = false;
            }

            if (TextBoxCodigoAuxiliar.Text == "")
            {
                TextBoxCodigoAuxiliar.Focus();
                Retorno = false;
            }

            if (TextBoxEstoque.DoubleValue == 0)
            {
                TextBoxEstoque.Focus();
                Retorno = false;
            }

            return Retorno;
        }
    }
}
