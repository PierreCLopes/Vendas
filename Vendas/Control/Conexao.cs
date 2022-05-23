using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Control
{
    public class Conexao
    {
        public static NpgsqlConnection GetConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=valeverde;Database=VENDA;");
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar banco: " + e.Message);
            }
            return conexao;
        }

        public static void SetFechaConexao(NpgsqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao fechar conexão banco: " + e.Message);
                }
            }
        }

    }
}
