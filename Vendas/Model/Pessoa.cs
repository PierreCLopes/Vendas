using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public class Pessoa
    {
        public int Handle { get; set; }
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public string Endereco { get; set; }
        public int Status { get; set; }
        public string StatusTraducao { get; set; }
        public DateTime StatusData { get; set; }
        public string Observacao { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }

        public Pessoa(int handle, string nome, string cnpjCpf, string endereco, int status, string statusTraducao, DateTime statusData, string observacao, 
                      DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            Nome = nome;
            CnpjCpf = cnpjCpf;
            Endereco = endereco;
            Status = status;
            StatusTraducao = statusTraducao;
            StatusData = statusData;
            Observacao = observacao;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }

        public Pessoa()
        {
            Handle = 0;
            Nome = "";
            CnpjCpf = "";
            Endereco = "";
            Status = 0;
            StatusTraducao = "";
            StatusData = DateTime.Now;
            Observacao = "";
            LogDataCadastro = DateTime.Now;
            LogDataAlteracao = DateTime.Now;
            LogUsuarioCadastro = 0;
            LogUsuarioAlteracao = 0;
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

        override public string ToString()
        {
            return Nome + " - " + CnpjCpf;
        }
    }
}
