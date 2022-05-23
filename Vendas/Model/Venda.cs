using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public class Venda
    {
        public int Handle { get; set; }
        public decimal ValorLiquido { get; set; }
        public int Cliente { get; set; }
        public DateTime Data { get; set; }
        public int Vendedor { get; set; }
        public string NumeroPedido { get; set; }
        public int Status { get; set; }
        public DateTime StatusData { get; set; }
        public string Observacao { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }

        public Venda(int handle, decimal valorLiquido, int cliente, DateTime data, int vendedor, 
                     string numeroPedido, int status, DateTime statusData, string observacao, 
                     DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            ValorLiquido = valorLiquido;
            Cliente = cliente;
            Data = data;
            Vendedor = vendedor;
            NumeroPedido = numeroPedido;
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
