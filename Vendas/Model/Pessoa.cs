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
        public int Status { get; set; }
        public DateTime StatusData { get; set; }
        public string Observacao { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }

        public Pessoa(int handle, string nome, string cnpjCpf, int status, DateTime statusData, string observacao, 
                      DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            Nome = nome;
            CnpjCpf = cnpjCpf;
            Status = status;
            StatusData = statusData;
            Observacao = observacao;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }
    }
}
