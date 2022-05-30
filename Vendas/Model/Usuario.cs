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
        public string StatusTraducao { get; set; }
        public DateTime StatusData { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }
        public bool Logado { get; set; }

        public Usuario(int handle, string login, string senha, int status, string statusTraducao, DateTime statusData, DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            Login = login;
            Senha = senha;
            Status = status;
            StatusTraducao = statusTraducao;
            StatusData = statusData;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }

        public Usuario()
        {
            Handle = 0;
            Login = "";
            Senha = "";
            Status = 0;
            StatusTraducao = "";
            StatusData = DateTime.Now;
            LogDataCadastro = DateTime.Now;
            LogDataAlteracao = DateTime.Now;
            LogUsuarioCadastro = 0;
            LogUsuarioAlteracao = 0;
            Logado = false;
        }

        public void Liberar()
        {
            Status = Model.Status.Ativo;
            StatusTraducao = "Ativo";
            StatusData = DateTime.Now;
        }

        public void Voltar()
        {
            Status = Model.Status.AgModificacao;
            StatusTraducao = "Ag. Modificações";
            StatusData = DateTime.Now;
        }

        public void Cancelar()
        {
            Status = Model.Status.Cancelado;
            StatusTraducao = "Cancelado";
            StatusData = DateTime.Now;
        }
    }
}
