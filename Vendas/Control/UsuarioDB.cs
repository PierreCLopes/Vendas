using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.Control
{
    public class UsuarioDB
    {
        public static List<Usuario> GetUsuarios(NpgsqlConnection conexao)
        {
            List<Usuario> Lista = new List<Usuario>();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                " FROM USUARIO A " +
                                "INNER JOIN STATUS B ON B.HANDLE = A.STATUS ";
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    string Login = DataReader["LOGIN"].ToString();
                    string Senha = DataReader["SENHA"].ToString();
                    int Status = int.Parse(DataReader["STATUS"].ToString());
                    String StatusTraducao = DataReader["STATUSNOME"].ToString();
                    DateTime StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    DateTime LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    DateTime LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    int LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    int LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());

                    Usuario vUsuario = new Usuario(Handle, Login, Senha, Status, StatusTraducao, StatusData, LogDataCadastro, LogDataAlteracao, LogUsuarioCadastro, LogUsuarioAlteracao);
                    Lista.Add(vUsuario);
                }
                DataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Lista;
        }

        public static Usuario GetUsuarioByHandle(NpgsqlConnection conexao, int prHandle)
        {
            Usuario vUsuario = new Usuario();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                " FROM USUARIO A " +
                                "INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                "WHERE A.HANDLE = " + prHandle.ToString();
                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                NpgsqlDataReader DataReader = vCommand.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    vUsuario.Handle = int.Parse(DataReader["HANDLE"].ToString());
                    vUsuario.Login = DataReader["LOGIN"].ToString();
                    vUsuario.Senha = DataReader["SENHA"].ToString();
                    vUsuario.Status = int.Parse(DataReader["STATUS"].ToString());
                    vUsuario.StatusTraducao = DataReader["STATUSNOME"].ToString();
                    vUsuario.StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    vUsuario.LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    vUsuario.LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    vUsuario.LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    vUsuario.LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return vUsuario;
        }

        public static int GetHandleInsert(NpgsqlConnection conexao)
        {
            int retorno = 0;
            try
            {
                string vQuery = "SELECT MAX(HANDLE) HANDLE " +
                                "  FROM USUARIO  ";
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

        public static bool SetInsereUsuario(Usuario usuario, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "INSERT INTO USUARIO (HANDLE, LOGIN, SENHA, STATUS, STATUSDATA, LOGDATACADASTRO, LOGDATAALTERACAO, LOGUSUARIOCADASTRO, LOGUSUARIOALTERACAO) " +
                              "VALUES (@HANDLE, @LOGIN, @SENHA, @STATUS, @STATUSDATA, @LOGDATACADASTRO, @LOGDATAALTERACAO, @LOGUSUARIOCADASTRO, @LOGUSUARIOALTERACAO)";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.Handle;
                vCommand.Parameters.Add("@LOGIN", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuario.Login;
                vCommand.Parameters.Add("@SENHA", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuario.Senha;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.StatusData; 
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.LogUsuarioAlteracao;
                
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

        public static bool SetAlteraUsuario(Usuario usuario, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "UPDATE USUARIO " +
                             "    SET LOGIN = @LOGIN," +
                             "        SENHA = @SENHA, " +
                             "        STATUS = @STATUS, " +
                             "        STATUSDATA = @STATUSDATA, " +
                             "        LOGDATACADASTRO = @LOGDATACADASTRO, " +
                             "        LOGDATAALTERACAO = @LOGDATAALTERACAO, " +
                             "        LOGUSUARIOCADASTRO = @LOGUSUARIOCADASTRO " +
                             "  WHERE HANDLE = @HANDLE";

                NpgsqlCommand vCommand = new NpgsqlCommand(vSql, conexao);
                vCommand.Parameters.Add("@HANDLE", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.Handle;
                vCommand.Parameters.Add("@LOGIN", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuario.Login;
                vCommand.Parameters.Add("@SENHA", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuario.Senha;
                vCommand.Parameters.Add("@STATUS", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.Status;
                vCommand.Parameters.Add("@STATUSDATA", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.StatusData;
                vCommand.Parameters.Add("@LOGDATACADASTRO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.LogDataCadastro;
                vCommand.Parameters.Add("@LOGDATAALTERACAO", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = usuario.LogDataAlteracao;
                vCommand.Parameters.Add("@LOGUSUARIOCADASTRO", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.LogUsuarioCadastro;
                vCommand.Parameters.Add("@LOGUSUARIOALTERACAO", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.LogUsuarioAlteracao;
                
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

        public static bool SetExcluirUsuario(int handle, NpgsqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string vSql = "DELETE FROM USUARIO WHERE HANDLE = @HANDLE";
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

        public static Usuario AutenticarUsuario(string Login, string Senha, NpgsqlConnection conexao)
        {
            Usuario usuario = new Usuario();
            try
            {
                string vQuery = "SELECT A.*, " +
                                "       B.NOME STATUSNOME " +
                                "  FROM USUARIO A" +
                                " INNER JOIN STATUS B ON B.HANDLE = A.STATUS " +
                                " WHERE A.LOGIN = @LOGIN " +
                                "   AND A.SENHA = @SENHA " +
                                "   AND A.STATUS = " + Status.Ativo.ToString();

                NpgsqlCommand vCommand = new NpgsqlCommand(vQuery, conexao);
                vCommand.Parameters.Add("@LOGIN", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Login;
                vCommand.Parameters.Add("@SENHA", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Senha;

                NpgsqlDataReader DataReader = vCommand.ExecuteReader();

                if(DataReader.HasRows)
                {
                    DataReader.Read();
                    int Handle = int.Parse(DataReader["HANDLE"].ToString());
                    int Status = int.Parse(DataReader["STATUS"].ToString());
                    string StatusTraducao = DataReader["STATUSNOME"].ToString();
                    DateTime StatusData = Convert.ToDateTime(DataReader["STATUSDATA"]);
                    DateTime LogDataCadastro = Convert.ToDateTime(DataReader["LOGDATACADASTRO"]);
                    DateTime LogDataAlteracao = Convert.ToDateTime(DataReader["LOGDATAALTERACAO"]);
                    int LogUsuarioCadastro = int.Parse(DataReader["LOGUSUARIOCADASTRO"].ToString());
                    int LogUsuarioAlteracao = int.Parse(DataReader["LOGUSUARIOALTERACAO"].ToString());

                    usuario.Login = Login;
                    usuario.Status = Status;
                    usuario.StatusTraducao = StatusTraducao;
                    usuario.Handle = Handle;
                    usuario.StatusData = StatusData;
                    usuario.LogDataCadastro = LogDataCadastro;
                    usuario.LogDataAlteracao = LogDataAlteracao;
                    usuario.LogUsuarioCadastro = LogUsuarioCadastro;
                    usuario.LogUsuarioAlteracao = LogUsuarioAlteracao;
                    usuario.Logado = true;
                }
                DataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return usuario;
        }
    }
}
