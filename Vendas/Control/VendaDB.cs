using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.Control
{
    public class VendaDB
    {
        public static List<Venda> GetVendas(NpgsqlConnection conexao)
        {
            List<Venda> Lista = new List<Venda>();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME, " +
                                "       C.NOME CLIENTENOME "  +
                                "  FROM VENDA A " +
                                " INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                " INNER JOIN PESSOA C ON C.HANDLE = A.CLIENTE ";
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    int Vendedor = int.Parse(DataReader["VENDEDOR"].ToString());
                    int Cliente = int.Parse(DataReader["CLIENTE"].ToString());
                    Decimal ValorLiquido = (decimal)DataReader["VALORLIQUIDO"];
                    string NumeroPedido = DataReader["NUMEROPEDIDO"].ToString();
                    string NomeCliente = DataReader["CLIENTENOME"].ToString();
                    string Observacao = DataReader["OBSERVACAO"].ToString();
                    int Status = int.Parse(DataReader["STATUS"].ToString());
                    String StatusTraducao = DataReader["STATUSNOME"].ToString();
                    DateTime StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    DateTime LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    DateTime LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    int LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    int LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());

                    Venda vVenda = new Venda(Handle, 
                                             ValorLiquido, 
                                             Cliente, 
                                             NomeCliente, 
                                             Vendedor, 
                                             NumeroPedido, 
                                             Status, 
                                             StatusTraducao, 
                                             StatusData, 
                                             Observacao, 
                                             LogDataCadastro, 
                                             LogDataAlteracao, 
                                             LogUsuarioCadastro, 
                                             LogUsuarioAlteracao);
                    Lista.Add(vVenda);
                }
                DataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Lista;
        }

        public static Venda GetVendaByHandle(NpgsqlConnection conexao, int prHandle)
        {
            Venda vVenda = new Venda();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME, " +
                                "       C.NOME CLIENTENOME " +
                                "  FROM VENDA A " +
                                " INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                " INNER JOIN PESSOA C ON C.HANDLE = A.CLIENTE " +
                                "WHERE A.HANDLE = " + prHandle.ToString();
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vVenda.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vVenda.Vendedor = int.Parse(DataReader["VENDEDOR"].ToString());
                    vVenda.Cliente = int.Parse(DataReader["CLIENTE"].ToString());
                    vVenda.ValorLiquido = (decimal)DataReader["VALORLIQUIDO"];
                    vVenda.NumeroPedido = DataReader["NUMEROPEDIDO"].ToString();
                    vVenda.NomeCliente = DataReader["CLIENTENOME"].ToString();
                    vVenda.Observacao = DataReader["OBSERVACAO"].ToString();
                    vVenda.Status = int.Parse(DataReader["STATUS"].ToString());
                    vVenda.StatusTraducao = DataReader["STATUSNOME"].ToString();
                    vVenda.StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    vVenda.LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    vVenda.LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    vVenda.LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    vVenda.LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vVenda;
        }

        public static int GetHandleInsert(NpgsqlConnection conexao)
        {
            int retorno = 0;
            try
            {
                string vQuery = "SELECT COALESCE(MAX(HANDLE), 0) HANDLE " +
                                "  FROM VENDA  ";
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    retorno = int.Parse(DataReader["HANDLE"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno + 1;
        }

        public static bool SetInsereVenda(Venda venda, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "INSERT INTO VENDA (HANDLE, CLIENTE, DATA, VALORLIQUIDO, NUMEROPEDIDO, VENDEDOR, OBSERVACAO, STATUS, STATUSDATA, LOGDATACADASTRO, LOGDATAALTERACAO, LOGUSUARIOCADASTRO, LOGUSUARIOALTERACAO) " +
                              "VALUES (@HANDLE, @CLIENTE, @DATA, @VALORLIQUIDO, @NUMEROPEDIDO, @VENDEDOR, @OBSERVACAO, @STATUS, @STATUSDATA, @LOGDATACADASTRO, @LOGDATAALTERACAO, @LOGUSUARIOCADASTRO, @LOGUSUARIOALTERACAO)";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Handle;
                vCommand.Parameters.Add("@CLIENTE", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Cliente;
                vCommand.Parameters.Add("@VALORLIQUIDO", NpgsqlTypes.NpgsqlDbType.Numeric).Value = venda.ValorLiquido;
                vCommand.Parameters.Add("@NUMEROPEDIDO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = venda.NumeroPedido;
                vCommand.Parameters.Add("@VENDEDOR", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Vendedor;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = venda.Observacao;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.StatusData;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.LogUsuarioAlteracao;

                int valor = vCommand.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno;
        }

        public static bool SetAlteraVenda(Venda venda, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "UPDATE VENDA " +
                             "    SET CLIENTE = @CLIENTE," +
                             "        VALORLIQUIDO = @VALORLIQUIDO, " +
                             "        NUMEROPEDIDO = @NUMEROPEDIDO, " +
                             "        VENDEDOR = @VENDEDOR, " +
                             "        OBSERVACAO = @OBSERVACAO, " +
                             "        STATUS = @STATUS, " +
                             "        STATUSDATA = @STATUSDATA, " +
                             "        LOGDATACADASTRO = @LOGDATACADASTRO, " +
                             "        LOGDATAALTERACAO = @LOGDATAALTERACAO, " +
                             "        LOGUSUARIOCADASTRO = @LOGUSUARIOCADASTRO " +
                             "  WHERE HANDLE = @HANDLE";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Handle;
                vCommand.Parameters.Add("@CLIENTE", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Cliente;
                vCommand.Parameters.Add("@VALORLIQUIDO", NpgsqlTypes.NpgsqlDbType.Numeric).Value = venda.ValorLiquido;
                vCommand.Parameters.Add("@NUMEROPEDIDO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = venda.NumeroPedido;
                vCommand.Parameters.Add("@VENDEDOR", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Vendedor;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = venda.Observacao;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.StatusData;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = venda.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = venda.LogUsuarioAlteracao;

                int valor = vCommand.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno;
        }

        public static bool SetExcluirVenda(int handle, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "DELETE FROM VENDA WHERE HANDLE = @HANDLE";
                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = handle;

                int valor = vCommand.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno;
        }

        public decimal GetValorTotal(NpgsqlConnection conexao, int prVenda)
        {
            decimal retorno = 0;
            try
            {
                string vQuery = "SELECT SUM(VALORTOTAL) VALORTOTAL " +
                                "  FROM VENDAPRODUTO  " +
                                " WHERE VENDA = " + prVenda.ToString();

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    retorno = (decimal)(DataReader["VALORTOTAL"]);
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno;
        }
    }
}
