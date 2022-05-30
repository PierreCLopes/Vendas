using Npgsql;
using Vendas.Control;
using Vendas.Model;
using Vendas.View;

namespace Vendas
{
    public partial class FormPrincipal : Form
    {
        NpgsqlConnection conexao = null;
        Usuario usuarioLogado = new Usuario();

        public FormPrincipal(NpgsqlConnection conexao, Usuario usuario)
        {
            this.conexao = conexao;
            this.usuarioLogado = usuario;
            InitializeComponent();

            this.Text += " - Usuário: " + usuarioLogado.Login;
            DataGridViewUsuario.AutoGenerateColumns = false;
            DataGridViewUsuario.AllowUserToResizeColumns = false;
            AtualizaTela();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao.SetFechaConexao(conexao);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizaTelaUsuario();
        }

        private void AtualizaTela()
        {
            DataGridViewUsuario.Visible = false;
            DataGridViewPessoa.Visible = false;
        }

        private void DataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotaoAbrir_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuario.Visible)
            {
                Usuario usuario = (Usuario)DataGridViewUsuario.CurrentRow.DataBoundItem;
                FormUsuario Form = new FormUsuario(conexao, usuario, usuarioLogado);
                Form.ShowDialog();
                AtualizaTelaUsuario();
            }
        }

        private void AtualizaTelaUsuario()
        {
            AtualizaTela();
            DataGridViewUsuario.Visible = true;

            List<Usuario> lista = UsuarioDB.GetUsuarios(conexao);
            DataGridViewUsuario.DataSource = lista;
        }

        private void BotaoInserir_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuario.Visible)
            {
                Usuario vUsuario = new Usuario();
                FormUsuario Form = new FormUsuario(conexao, vUsuario, usuarioLogado);
                Form.ShowDialog();
            }
        }
    }
}