using Npgsql;
using Vendas.Control;
using Vendas.Model;
using Vendas.View;

namespace Vendas
{
    public partial class FormPrincipal : Form
    {
        NpgsqlConnection conexao = null;
        Usuario usuario = new Usuario();

        public FormPrincipal(NpgsqlConnection conexao, Usuario usuario)
        {
            this.conexao = conexao;
            this.usuario = usuario;
            InitializeComponent();

            this.Text += " - Usuário: " + usuario.Login;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao.SetFechaConexao(conexao);
        }
    }
}