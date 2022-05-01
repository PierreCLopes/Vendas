using Npgsql;

namespace Vendas
{
    public partial class FormPrincipal : Form
    {
        NpgsqlConnection Conexao = null;

        public FormPrincipal()
        {
            InitializeComponent();
            Conexao = new NpgsqlConnection();
        }
    }
}