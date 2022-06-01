using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.Control
{
    public class ProdutoDB
    {
        public static List<Produto> GetProdutos(NpgsqlConnection conexao)
        {
            List<Produto> Lista = new List<Produto>();
            try
            {
                string vQuery = "SELECT * " +
                                " FROM PRODUTO ";

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    string Nome = DataReader["NOME"].ToString();
                    string CodigoAuxiliar = DataReader["CODIGOAUXILIAR"].ToString();
                    string Descricao = DataReader["DESCRICAO"].ToString();
                    decimal Valor = (decimal)DataReader["VALOR"];
                    decimal Estoque = (decimal)DataReader["ESTOQUE"];
                    DateTime LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    DateTime LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    int LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    int LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());

                    Produto vProduto = new Produto(Handle, 
                                                   Nome, 
                                                   Valor,
                                                   CodigoAuxiliar, 
                                                   Estoque, 
                                                   Descricao, 
                                                   LogDataCadastro, 
                                                   LogDataAlteracao, 
                                                   LogUsuarioCadastro, 
                                                   LogUsuarioAlteracao);
                    Lista.Add(vProduto);
                }
                DataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Lista;
        }

        public static Produto GetProdutoByHandle(NpgsqlConnection conexao, int prHandle)
        {
            Produto vProduto = new Produto();
            try
            {
                string vQuery = "SELECT * " +
                                " FROM PRODUTO " +
                                "WHERE HANDLE = " + prHandle.ToString();
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vProduto.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vProduto.Nome = DataReader["NOME"].ToString();
                    vProduto.CodigoAuxiliar = DataReader["CODIGOAUXILIAR"].ToString();
                    vProduto.Descricao = DataReader["DESCRICAO"].ToString();
                    vProduto.Valor = (decimal)DataReader["VALOR"];
                    vProduto.Estoque = (decimal)DataReader["ESTOQUE"];
                    vProduto.LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    vProduto.LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    vProduto.LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    vProduto.LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vProduto;
        }

        public static int GetHandleInsert(NpgsqlConnection conexao)
        {
            int retorno = 0;
            try
            {
                string vQuery = "SELECT COALESCE(MAX(HANDLE), 0) HANDLE " +
                                "  FROM PRODUTO  ";
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

        public static bool GetExisteVenda(NpgsqlConnection conexao, int prHandle)
        {
            bool retorno = false;
            try
            {
                string vQuery = "SELECT COUNT(B.HANDLE) VENDA" +
                                "  FROM PRODUTO  A " +
                                " INNER JOIN VENDAPRODUTO B ON B.PRODUTO = A.HANDLE " +
                                " WHERE A.HANDLE = " + prHandle.ToString();

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    retorno = int.Parse(DataReader["VENDA"].ToString()) > 0;
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return retorno;
        }

        public static bool SetInsereProduto(Produto produto, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "INSERT INTO PRODUTO (HANDLE, NOME, VALOR, ESTOQUE, DESCRICAO, CODIGOAUXILIAR, LOGDATACADASTRO, LOGDATAALTERACAO, LOGUSUARIOCADASTRO, LOGUSUARIOALTERACAO) " +
                              "VALUES (@HANDLE, @NOME, @VALOR, @ESTOQUE, @DESCRICAO, @CODIGOAUXILIAR, @LOGDATACADASTRO, @LOGDATAALTERACAO, @LOGUSUARIOCADASTRO, @LOGUSUARIOALTERACAO)";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Handle;
                vCommand.Parameters.Add("@NOME", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.Nome;
                vCommand.Parameters.Add("@VALOR", NpgsqlTypes.NpgsqlDbType.Numeric).Value = produto.Valor;
                vCommand.Parameters.Add("@ESTOQUE", NpgsqlTypes.NpgsqlDbType.Numeric).Value = produto.Estoque;
                vCommand.Parameters.Add("@DESCRICAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.Descricao;
                vCommand.Parameters.Add("@CODIGOAUXILIAR", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.CodigoAuxiliar;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = produto.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = produto.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.LogUsuarioAlteracao;

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

        public static bool SetAlteraProduto(Produto produto, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "UPDATE PRODUTO " +
                             "    SET NOME = @NOME," +
                             "        VALOR = @VALOR, " +
                             "        ESTOQUE = @ESTOQUE, " +
                             "        DESCRICAO = @DESCRICAO, " +
                             "        CODIGOAUXILIAR = @CODIGOAUXILIAR, " +
                             "        LOGDATACADASTRO = @LOGDATACADASTRO, " +
                             "        LOGDATAALTERACAO = @LOGDATAALTERACAO, " + 
                             "        LOGUSUARIOCADASTRO = @LOGUSUARIOCADASTRO " +
                             "  WHERE HANDLE = @HANDLE";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Handle;
                vCommand.Parameters.Add("@NOME", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.Nome;
                vCommand.Parameters.Add("@VALOR", NpgsqlTypes.NpgsqlDbType.Numeric).Value = produto.Valor;
                vCommand.Parameters.Add("@ESTOQUE", NpgsqlTypes.NpgsqlDbType.Numeric).Value = produto.Estoque;
                vCommand.Parameters.Add("@DESCRICAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.Descricao;
                vCommand.Parameters.Add("@CODIGOAUXILIAR", NpgsqlTypes.NpgsqlDbType.Varchar).Value = produto.CodigoAuxiliar;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = produto.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = produto.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.LogUsuarioAlteracao;

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

        public static bool SetExcluirProduto(int handle, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "DELETE FROM PRODUTO WHERE HANDLE = @HANDLE";
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
    }
}

