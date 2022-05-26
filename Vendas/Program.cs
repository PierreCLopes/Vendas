using Npgsql;
using Vendas.Control;
using Vendas.View;

namespace Vendas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NpgsqlConnection conexao = null;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            conexao = Conexao.GetConexao();
            FormLogin Form = new FormLogin(conexao);
            Form.ShowDialog();

            if (Form.usuario.Logado)
            {
                Application.Run(new FormPrincipal(conexao, Form.usuario));
            }
        }
    }
}