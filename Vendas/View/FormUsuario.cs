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
    public partial class FormUsuario : Form
    {
        Usuario usuario;
        Usuario usuarioLogado;
        NpgsqlConnection conexao;
        bool inserindo;

        public FormUsuario(NpgsqlConnection prConexao, Usuario prUsuario, Usuario prUsuarioLogado)
        {
            usuario = prUsuario;
            usuarioLogado = prUsuarioLogado;
            conexao = prConexao;
            inserindo = (usuario.Handle == 0);
            InitializeComponent();

            PreencherCampos();
            AtualizarPermissoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Auditoria();
            }
        }

        private void Auditoria()
        {
            FormAuditoria Form = new FormAuditoria(usuario.LogDataCadastro, 
                                                   usuario.LogDataAlteracao, 
                                                   UsuarioDB.GetUsuarioByHandle(conexao, usuario.LogUsuarioCadastro).Login,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, usuario.LogUsuarioAlteracao).Login);
            Form.ShowDialog();
        }

        private void AtualizarPermissoes()
        {
            BotaoExcluir.Enabled = usuario.Status == Status.Cadastrado;
            BotaoCancelar.Enabled = usuario.Status == Status.AgModificacao;
            BotaoLiberar.Enabled = (usuario.Status == Status.Cadastrado) ^ (usuario.Status == Status.AgModificacao);
            BotaoVoltar.Enabled = (usuario.Status == Status.Ativo) ^ (usuario.Status == Status.Cancelado);
            BotaoSalvar.Enabled = !(usuario.Status == Status.Ativo) && !(usuario.Status == Status.Cancelado);
            TextBoxLogin.ReadOnly = !BotaoSalvar.Enabled;
            TextBoxSenha.ReadOnly = !BotaoSalvar.Enabled;
        }

        private void PreencherCampos()
        {
            TextBoxHandle.Text = usuario.Handle.ToString();
            TextBoxLogin.Text = usuario.Login;
            TextBoxSenha.Text = usuario.Senha;

            if (!inserindo)
            {
                this.Text = usuario.StatusTraducao + " desde " + usuario.StatusData.ToString();
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (!inserindo)
            {
                usuario.Login = TextBoxLogin.Text;
                usuario.Senha = TextBoxSenha.Text;
                usuario.LogDataAlteracao = DateTime.Now;
                usuario.LogUsuarioAlteracao = usuarioLogado.Handle;

                UsuarioDB.SetAlteraUsuario(usuario, conexao);

                PreencherCampos();
            }
            else
            {
                usuario.Handle = UsuarioDB.GetHandleInsert(conexao);
                usuario.Login = TextBoxLogin.Text;
                usuario.Senha = TextBoxSenha.Text;
                usuario.Status = Status.Cadastrado;
                usuario.StatusTraducao = "Cadastrado";
                usuario.StatusData = DateTime.Now;
                usuario.LogDataAlteracao = DateTime.Now;
                usuario.LogUsuarioAlteracao = usuarioLogado.Handle;
                usuario.LogDataCadastro = DateTime.Now;
                usuario.LogUsuarioCadastro = usuarioLogado.Handle;

                inserindo = !UsuarioDB.SetInsereUsuario(usuario, conexao);

                PreencherCampos();
            }    
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja excluir o usuário " + usuario.Login + "?"
                        , "Usuário"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                bool retorno = UsuarioDB.SetExcluirUsuario(usuario.Handle, conexao);
                if (retorno)
                {
                    MessageBox.Show("Sucesso, usuário excluído!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro, usuário não excluído!");
                }
            }
        }

        private void BotaoLiberar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente liberar o usuário " + usuario.Login + "?"
                        , "Usuário"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                usuario.Liberar();
                UsuarioDB.SetAlteraUsuario(usuario, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente voltar o usuário " + usuario.Login + "?"
                        , "Usuário"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                usuario.Voltar();
                UsuarioDB.SetAlteraUsuario(usuario, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente cancelar o usuário " + usuario.Login + "?"
                        , "Usuário"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                usuario.Cancelar();
                UsuarioDB.SetAlteraUsuario(usuario, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }
    }
}
