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
using Vendas.Model;

namespace Vendas.View
{
    public partial class FormProduto : Form
    {
        Produto produto;
        Usuario usuarioLogado;
        NpgsqlConnection conexao;
        bool inserindo;

        public FormProduto(NpgsqlConnection prConexao, Produto prProduto, Usuario prUsuarioLogado)
        {
            produto = prProduto;
            usuarioLogado = prUsuarioLogado;
            conexao = prConexao;
            inserindo = (produto.Handle == 0);
            InitializeComponent();

            PreencherCampos();
            AtualizarPermissoes();
        }

        private void FormProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Auditoria();
            }
        }

        private void Auditoria()
        {
            FormAuditoria Form = new FormAuditoria(produto.LogDataCadastro,
                                                   produto.LogDataAlteracao,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, produto.LogUsuarioCadastro).Login,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, produto.LogUsuarioAlteracao).Login);
            Form.ShowDialog();
        }

        private void AtualizarPermissoes()
        {
            BotaoExcluir.Enabled = !ProdutoDB.GetExisteVenda(conexao, produto.Handle);
        }

        private void PreencherCampos()
        {
            TextBoxHandle.Text =  produto.Handle.ToString();
            TextBoxNome.Text = produto.Nome;
            TextBoxValor.Text = produto.Valor.ToString();
            TextBoxEstoque.Text = produto.Estoque.ToString();
            TextBoxDescricao.Text = produto.Descricao;
            TextBoxCodigoAuxiliar.Text = produto.CodigoAuxiliar;
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (!inserindo)
                {
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
                    produto.Handle = ProdutoDB.GetHandleInsert(conexao);
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
