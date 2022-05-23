using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public class Usuario
    {
        public int Handle { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
        public DateTime StatusData { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }

        public Usuario(int handle, string login, string senha, int status, DateTime statusData, DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            Login = login;
            Senha = senha;
            Status = status;
            StatusData = statusData;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }
    }
}
