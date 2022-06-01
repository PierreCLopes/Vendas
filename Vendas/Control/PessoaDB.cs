using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.Control
{
    public class PessoaDB
    {
        public static List<Pessoa> GetPessoas(NpgsqlConnection conexao, int prStatus = 0)
        {
            List<Pessoa> Lista = new List<Pessoa>();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                " FROM PESSOA A " +
                                "INNER JOIN STATUS B ON B.HANDLE = A.STATUS ";

                if (prStatus != 0)
                {
                    vQuery += " AND A.STATUS = " + prStatus.ToString();
                }

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    string Nome = DataReader["NOME"].ToString();
                    string CnpjCpf = DataReader["CNPJCPF"].ToString();
                    string Endereco = DataReader["ENDERECO"].ToString();
                    string Observacao = DataReader["OBSERVACAO"].ToString();
                    int Status = int.Parse(DataReader["STATUS"].ToString());
                    String StatusTraducao = DataReader["STATUSNOME"].ToString();
                    DateTime StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    DateTime LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    DateTime LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    int LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    int LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());

                    Pessoa vPessoa = new Pessoa(Handle, Nome, CnpjCpf, Endereco, Status, StatusTraducao, StatusData, Observacao, LogDataCadastro, LogDataAlteracao, LogUsuarioCadastro, LogUsuarioAlteracao);
                    Lista.Add(vPessoa);
                }
                DataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Lista;
        }

        public static Pessoa GetPessoaByHandle(NpgsqlConnection conexao, int prHandle)
        {
            Pessoa vPessoa = new Pessoa();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                " FROM PESSOA A " +
                                "INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                "WHERE A.HANDLE = " + prHandle.ToString();
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vPessoa.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vPessoa.Nome = DataReader["NOME"].ToString();
                    vPessoa.CnpjCpf = DataReader["CNPJCPF"].ToString();
                    vPessoa.Endereco = DataReader["ENDERECO"].ToString();
                    vPessoa.Observacao = DataReader["OBSERVACAO"].ToString();
                    vPessoa.Status = int.Parse(DataReader["STATUS"].ToString());
                    vPessoa.StatusTraducao = DataReader["STATUSNOME"].ToString();
                    vPessoa.StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    vPessoa.LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    vPessoa.LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    vPessoa.LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    vPessoa.LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vPessoa;
        }

        public static Pessoa GetPessoaByCnpjCpf(NpgsqlConnection conexao, string CnpjCpf)
        {
            Pessoa vPessoa = new Pessoa();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                " FROM PESSOA A " +
                                "INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                "WHERE A.CNPJCPF = '" + CnpjCpf + "'";
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vPessoa.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vPessoa.Nome = DataReader["NOME"].ToString();
                    vPessoa.CnpjCpf = DataReader["CNPJCPF"].ToString();
                    vPessoa.Endereco = DataReader["ENDERECO"].ToString();
                    vPessoa.Observacao = DataReader["OBSERVACAO"].ToString();
                    vPessoa.Status = int.Parse(DataReader["STATUS"].ToString());
                    vPessoa.StatusTraducao = DataReader["STATUSNOME"].ToString();
                    vPessoa.StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    vPessoa.LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    vPessoa.LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    vPessoa.LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    vPessoa.LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vPessoa;
        }

        public static int GetHandleInsert(NpgsqlConnection conexao)
        {
            int retorno = 0;
            try
            {
                string vQuery = "SELECT COALESCE(MAX(HANDLE), 0) HANDLE " +
                                "  FROM PESSOA  ";
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

        public static bool SetInserePessoa(Pessoa pessoa, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "INSERT INTO PESSOA (HANDLE, NOME, CNPJCPF, ENDERECO, OBSERVACAO, STATUS, STATUSDATA, LOGDATACADASTRO, LOGDATAALTERACAO, LOGUSUARIOCADASTRO, LOGUSUARIOALTERACAO) " +
                              "VALUES (@HANDLE, @NOME, @CNPJCPF, @ENDERECO, @OBSERVACAO, @STATUS, @STATUSDATA, @LOGDATACADASTRO, @LOGDATAALTERACAO, @LOGUSUARIOCADASTRO, @LOGUSUARIOALTERACAO)";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.Handle;
                vCommand.Parameters.Add("@NOME", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Nome;
                vCommand.Parameters.Add("@CNPJCPF", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.CnpjCpf;
                vCommand.Parameters.Add("@ENDERECO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Endereco;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Observacao;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.StatusData;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.LogUsuarioAlteracao;

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

        public static bool SetAlteraPessoa(Pessoa pessoa, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "UPDATE PESSOA " +
                             "    SET NOME = @NOME," +
                             "        CNPJCPF = @CNPJCPF, " +
                             "        ENDERECO = @ENDERECO, " +
                             "        OBSERVACAO = @OBSERVACAO, " +
                             "        STATUS = @STATUS, " +
                             "        STATUSDATA = @STATUSDATA, " +
                             "        LOGDATACADASTRO = @LOGDATACADASTRO, " +
                             "        LOGDATAALTERACAO = @LOGDATAALTERACAO, " +
                             "        LOGUSUARIOCADASTRO = @LOGUSUARIOCADASTRO " +
                             "  WHERE HANDLE = @HANDLE";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.Handle;
                vCommand.Parameters.Add("@NOME", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Nome;
                vCommand.Parameters.Add("@CNPJCPF", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.CnpjCpf;
                vCommand.Parameters.Add("@ENDERECO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Endereco;
                vCommand.Parameters.Add("@OBSERVACAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.Observacao;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.StatusData;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = pessoa.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.LogUsuarioAlteracao;

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

        public static bool SetExcluirPessoa(int handle, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "DELETE FROM PESSOA WHERE HANDLE = @HANDLE";
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
