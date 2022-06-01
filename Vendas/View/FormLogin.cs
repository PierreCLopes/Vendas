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
    public partial class FormLogin : Form
    {
        public Usuario usuario { get; set; }

        NpgsqlConnection conexao = null;

        public FormLogin(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();

            usuario = new Usuario();
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                usuario = UsuarioDB.AutenticarUsuario(TextLogin.Text, TextSenha.Text, conexao);

                if (usuario.Logado)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro: Usuário ou Senha incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }

        private bool VerificarCampos()
        {
            bool Retorno = true;

            if(TextLogin.Text == "")
            {
                TextLogin.Focus();
                Retorno = false;
            }

            if (TextSenha.Text == "")
            {
                TextSenha.Focus();
                Retorno = false;
            }

            return Retorno;
        }
    }
}
