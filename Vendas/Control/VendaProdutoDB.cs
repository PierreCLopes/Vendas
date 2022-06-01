using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.Control
{
    public class VendaProdutoDB
    {
        public static List<VendaProduto> GetVendaProdutos(NpgsqlConnection conexao, int prVenda)
        {
            List<VendaProduto> Lista = new List<VendaProduto>();
            try
            {
                string vQuery = "SELECT * " +
                                " FROM VENDAPRODUTO ";

                if (prVenda != 0)
                {
                    vQuery += " WHERE VENDA = " + prVenda.ToString();
                }

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    int Produto = int.Parse(DataReader["PRODUTO"].ToString());
                    decimal Quantidade = (decimal)DataReader["QUANTIDADE"];
                    decimal ValorUnitario = (decimal)DataReader["VALORUNITARIO"];
                    decimal ValorTotal = (decimal)DataReader["VALORTOTAL"];
                    string Observacao = DataReader["OBSERVACAO"].ToString();
                    int Venda = int.Parse(DataReader["VENDA"].ToString());

                    VendaProduto vVendaProduto = new VendaProduto(Handle,
                                                                  Observacao,
                                                                  Produto,
                                                                  Quantidade,
                                                                  ValorUnitario,
                                                                  ValorTotal,
                                                                  Venda);
                    Lista.Add(vVendaProduto);
                }
                DataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Lista;
        }

        public static VendaProduto GetVendaProdutoByHandle(NpgsqlConnection conexao, int prHandle)
        {
            VendaProduto vVendaProduto = new VendaProduto();
            try
            {
                string vQuery = "SELECT * " +
                                "  FROM VENDAPRODUTO " +
                                " WHERE HANDLE = " + prHandle.ToString();
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vVendaProduto.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vVendaProduto.Produto = int.Parse(DataReader["PRODUTO"].ToString());
                    vVendaProduto.Quantidade = (decimal)DataReader["QUANTIDADE"];
                    vVendaProduto.ValorUnitario = (decimal)DataReader["VALORUNITARIO"];
                    vVendaProduto.ValorTotal = (decimal)DataReader["VALORTOTAL"];
                    vVendaProduto.Observacao = DataReader["OBSERVACAO"].ToString();
                    vVendaProduto.Venda = int.Parse(DataReader["VENDA"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vVendaProduto;
        }

        public static int GetHandleInsert(NpgsqlConnection conexao)
        {
            int retorno = 0;
            try
            {
                string vQuery = "SELECT COALESCE(MAX(HANDLE), 0) HANDLE " +
                                "  FROM VENDAPRODUTO  ";
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

        public static bool SetInsereVendaProduto(VendaProduto vendaProduto, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "INSERT INTO VENDAPRODUTO (HANDLE, PRODUTO, QUANTIDADE, VALORUNITARIO, VALORTOTAL, OBSERVACAO, VENDA) " +
                              "VALUES (@HANDLE, @PRODUTO, @VALOR, @QUANTIDADE, @VALORUNITARIO, @VALORTOTAL, @OBSERVACAO, @VENDA)";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Handle;
                vCommand.Parameters.Add("@PRODUTO", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Produto;
                vCommand.Parameters.Add("@QUANTIDADE", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.Quantidade;
                vCommand.Parameters.Add("@VALORUNITARIO", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.ValorUnitario;
                vCommand.Parameters.Add("@VALORTOTAL", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.ValorTotal;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = vendaProduto.Observacao;
                vCommand.Parameters.Add("@VENDA", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Venda;

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

        public static bool SetAlteraVendaProduto(VendaProduto vendaProduto, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "UPDATE VENDAPRODUTO " +
                             "    SET PRODUTO = @PRODUTO," +
                             "        QUANTIDADE = @QUANTIDADE, " +
                             "        VALORUNITARIO = @VALORUNITARIO, " +
                             "        VALORTOTAL = @VALORTOTAL, " +
                             "        OBSERVACAO = @OBSERVACAO, " +
                             "        VENDA = @VENDA " +
                             "  WHERE HANDLE = @HANDLE";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Handle;
                vCommand.Parameters.Add("@PRODUTO", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Produto;
                vCommand.Parameters.Add("@QUANTIDADE", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.Quantidade;
                vCommand.Parameters.Add("@VALORUNITARIO", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.ValorUnitario;
                vCommand.Parameters.Add("@VALORTOTAL", NpgsqlTypes.NpgsqlDbType.Numeric).Value = vendaProduto.ValorTotal;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = vendaProduto.Observacao;
                vCommand.Parameters.Add("@VENDA", NpgsqlTypes.NpgsqlDbType.Integer).Value = vendaProduto.Venda;

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

        public static bool SetExcluirVendaProduto(int handle, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "DELETE FROM VENDAPRODUTO WHERE HANDLE = @HANDLE";
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
