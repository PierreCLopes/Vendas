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
        public string NomeCliente { get; set; }
        public int Vendedor { get; set; }
        public string NumeroPedido { get; set; }
        public int Status { get; set; }
        public string StatusTraducao { get; set; }
        public DateTime StatusData { get; set; }
        public string Observacao { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }

        public Venda(int handle, decimal valorLiquido, int cliente, string nomeCliente, int vendedor, 
                     string numeroPedido, int status, string statusTraducao, DateTime statusData, string observacao, 
                     DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            ValorLiquido = valorLiquido;
            Cliente = cliente;
            NomeCliente = nomeCliente;
            Vendedor = vendedor;
            NumeroPedido = numeroPedido;
            Status = status;
            StatusTraducao = statusTraducao;
            StatusData = statusData;
            Observacao = observacao;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }

        public Venda()
        {
            Handle = 0;
            ValorLiquido = 0;
            Cliente = 0;
            NomeCliente = "";
            Vendedor = 0;
            NumeroPedido = "";
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
            Status = Model.Status.AgEntrega;
            StatusTraducao = "Ag. Entrega";
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

        public void Entregar()
        {
            Status = Model.Status.Encerrado;
            StatusTraducao = "Encerrado";
            StatusData = DateTime.Now;
        }
    }
}
