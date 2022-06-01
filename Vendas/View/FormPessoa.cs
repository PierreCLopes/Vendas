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
    public partial class FormPessoa : Form
    {
        Pessoa pessoa;
        Usuario usuarioLogado;
        NpgsqlConnection conexao;
        bool inserindo;

        public FormPessoa(NpgsqlConnection prConexao, Pessoa prPessoa, Usuario prUsuarioLogado)
        {
            pessoa = prPessoa;
            usuarioLogado = prUsuarioLogado;
            conexao = prConexao;
            inserindo = (pessoa.Handle == 0);
            InitializeComponent();

            PreencherCampos();
            AtualizarPermissoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Auditoria();
            }
        }

        private void Auditoria()
        {
            FormAuditoria Form = new FormAuditoria(pessoa.LogDataCadastro,
                                                   pessoa.LogDataAlteracao,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, pessoa.LogUsuarioCadastro).Login,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, pessoa.LogUsuarioAlteracao).Login);
            Form.ShowDialog();
        }

        private void AtualizarPermissoes()
        {
            BotaoExcluir.Enabled = pessoa.Status == Status.Cadastrado;
            BotaoCancelar.Enabled = pessoa.Status == Status.AgModificacao;
            BotaoLiberar.Enabled = (pessoa.Status == Status.Cadastrado) ^ (pessoa.Status == Status.AgModificacao);
            BotaoVoltar.Enabled = (pessoa.Status == Status.Ativo) ^ (pessoa.Status == Status.Cancelado);
            BotaoSalvar.Enabled = !(pessoa.Status == Status.Ativo) && !(pessoa.Status == Status.Cancelado);

            TextBoxNome.ReadOnly = !BotaoSalvar.Enabled;
            TextBoxCnpjCpf.ReadOnly = !BotaoSalvar.Enabled;
            TextBoxEndereco.ReadOnly = !BotaoSalvar.Enabled;
            TextBoxObservacao.ReadOnly = !BotaoSalvar.Enabled;
        }

        private void PreencherCampos()
        {
            TextBoxHandle.Text = pessoa.Handle.ToString();
            TextBoxNome.Text = pessoa.Nome;
            TextBoxCnpjCpf.Text = pessoa.CnpjCpf;
            TextBoxEndereco.Text = pessoa.Endereco;
            TextBoxObservacao.Text = pessoa.Observacao;

            if (!inserindo)
            {
                this.Text = pessoa.StatusTraducao + " desde " + pessoa.StatusData.ToString();
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            { 
                if (!inserindo)
                {
                    pessoa.Nome = TextBoxNome.Text;
                    pessoa.CnpjCpf = TextBoxCnpjCpf.Text;
                    pessoa.Endereco = TextBoxEndereco.Text;
                    pessoa.Observacao = TextBoxObservacao.Text;
                    pessoa.LogDataAlteracao = DateTime.Now;
                    pessoa.LogUsuarioAlteracao = usuarioLogado.Handle;

                    PessoaDB.SetAlteraPessoa(pessoa, conexao);

                    PreencherCampos();
                }
                else
                {
                    pessoa.Handle = PessoaDB.GetHandleInsert(conexao);
                    pessoa.Nome = TextBoxNome.Text;
                    pessoa.CnpjCpf = TextBoxCnpjCpf.Text;
                    pessoa.Endereco = TextBoxEndereco.Text;
                    pessoa.Observacao = TextBoxObservacao.Text;
                    pessoa.Status = Status.Cadastrado;
                    pessoa.StatusTraducao = "Cadastrado";
                    pessoa.StatusData = DateTime.Now;
                    pessoa.LogDataAlteracao = DateTime.Now;
                    pessoa.LogUsuarioAlteracao = usuarioLogado.Handle;
                    pessoa.LogDataCadastro = DateTime.Now;
                    pessoa.LogUsuarioCadastro = usuarioLogado.Handle;

                    inserindo = !PessoaDB.SetInserePessoa(pessoa, conexao);

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
                        , $"Deseja excluir a pessoa " + pessoa.Nome + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                bool retorno = PessoaDB.SetExcluirPessoa(pessoa.Handle, conexao);
                if (retorno)
                {
                    MessageBox.Show("Sucesso, pessoa excluídaa!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro, pessoa não excluída!");
                }
            }
        }

        private void BotaoLiberar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente liberar a pessoa " + pessoa.Nome + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                pessoa.Liberar();
                PessoaDB.SetAlteraPessoa(pessoa, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente voltar a pessoaa " + pessoa.Nome + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                pessoa.Voltar();
                PessoaDB.SetAlteraPessoa(pessoa, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente cancelar a pessoa " + pessoa.Nome + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                pessoa.Cancelar();
                PessoaDB.SetAlteraPessoa(pessoa, conexao);
                PreencherCampos();
                AtualizarPermissoes();
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

            if (TextBoxCnpjCpf.Text == "")
            {
                TextBoxCnpjCpf.Focus();
                Retorno = false;
            }

            if (TextBoxEndereco.Text == "")
            {
                TextBoxEndereco.Focus();
                Retorno = false;
            }

            return Retorno;
        }
    }

}

