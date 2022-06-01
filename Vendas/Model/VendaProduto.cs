using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public class VendaProduto
    {
        public int Handle { get; set; }
        public string Observacao { get; set; }
        public int Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public int Venda { get; set; }

        public VendaProduto(int handle, string observacao, int produto, decimal quantidade, decimal valorUnitario, decimal valorTotal, int venda)
        {
            Handle = handle;
            Observacao = observacao;
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            Venda = venda;
        }

        public VendaProduto(int venda)
        {
            Handle = 0;
            Observacao = "";
            Produto = 0;
            Quantidade = 0;
            ValorUnitario = 0;
            ValorTotal = 0;
            Venda = venda;
        }
    }
}
