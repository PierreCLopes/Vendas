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
            DataGridViewPessoa.AutoGenerateColumns = false;
            DataGridViewPessoa.AllowUserToResizeColumns = false;
            DataGridViewProduto.AutoGenerateColumns = false;
            DataGridViewProduto.AllowUserToResizeColumns = false;
            DataGridViewVenda.AutoGenerateColumns = false;
            DataGridViewVenda.AllowUserToResizeColumns = false;

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
            DataGridViewProduto.Visible = false;
            DataGridViewVenda.Visible = false;
        }

        private void BotaoAbrir_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuario.Visible)
            {
                Usuario vUsuario = (Usuario)DataGridViewUsuario.CurrentRow.DataBoundItem;
                FormUsuario Form = new FormUsuario(conexao, vUsuario, usuarioLogado);
                Form.ShowDialog();
                AtualizaTelaUsuario();
            }
            else if (DataGridViewPessoa.Visible)
            {
                Pessoa vPessoa = (Pessoa)DataGridViewPessoa.CurrentRow.DataBoundItem;
                FormPessoa Form = new FormPessoa(conexao, vPessoa, usuarioLogado);
                Form.ShowDialog();
                AtualizaTelaPessoa();
            }
            else if (DataGridViewProduto.Visible)
            {
                Produto vProduto = (Produto)DataGridViewProduto.CurrentRow.DataBoundItem;
                FormProduto Form = new FormProduto(conexao, vProduto, usuarioLogado);
                Form.ShowDialog();
                AtualizaTelaProduto();
            }
            else if (DataGridViewVenda.Visible)
            {
                Venda vVenda = (Venda)DataGridViewVenda.CurrentRow.DataBoundItem;
                FormVenda Form = new FormVenda(conexao, vVenda, usuarioLogado);
                Form.ShowDialog();
                AtualizaTelaVenda();
            }
        }

        private void AtualizaTelaUsuario()
        {
            AtualizaTela();
            DataGridViewUsuario.Visible = true;

            List<Usuario> lista = UsuarioDB.GetUsuarios(conexao);
            DataGridViewUsuario.DataSource = lista;
        }

        private void AtualizaTelaPessoa()
        {
            AtualizaTela();
            DataGridViewPessoa.Visible = true;

            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            DataGridViewPessoa.DataSource = lista;
        }

        private void AtualizaTelaProduto()
        {
            AtualizaTela();
            DataGridViewProduto.Visible = true;

            List<Produto> lista = ProdutoDB.GetProdutos(conexao);
            DataGridViewProduto.DataSource = lista;
        }

        private void AtualizaTelaVenda()
        {
            AtualizaTela();
            DataGridViewVenda.Visible = true;

            List<Venda> lista = VendaDB.GetVendas(conexao);
            DataGridViewVenda.DataSource = lista;
        }

        private void BotaoInserir_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuario.Visible)
            {
                Usuario vUsuario = new Usuario();
                FormUsuario Form = new FormUsuario(conexao, vUsuario, usuarioLogado);
                Form.ShowDialog();
            }
            else if (DataGridViewPessoa.Visible)
            {
                Pessoa vPessoa = new Pessoa();
                FormPessoa Form = new FormPessoa(conexao, vPessoa, usuarioLogado);
                Form.ShowDialog();
            }
            else if (DataGridViewProduto.Visible)
            {
                Produto vProduto = new Produto();
                FormProduto Form = new FormProduto(conexao, vProduto, usuarioLogado);
                Form.ShowDialog();
            }
            else if (DataGridViewVenda.Visible)
            {
                Venda vVenda = new Venda();
                FormVenda Form = new FormVenda(conexao, vVenda, usuarioLogado);
                Form.ShowDialog();
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizaTelaPessoa();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizaTelaProduto();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizaTelaVenda();
        }
    }
}