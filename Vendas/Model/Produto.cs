using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public class Produto
    {
        public int Handle { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string CodigoAuxiliar { get; set; }
        public decimal Estoque { get; set; }
        public string Descricao { get; set; }
        public DateTime LogDataCadastro { get; set; }
        public DateTime LogDataAlteracao { get; set; }
        public int LogUsuarioCadastro { get; set; }
        public int LogUsuarioAlteracao { get; set; }


        public Produto(int handle, string nome, decimal valor, string codigoAuxiliar, decimal estoque, string descricao, 
                       DateTime logDataCadastro, DateTime logDataAlteracao, int logUsuarioCadastro, int logUsuarioAlteracao)
        {
            Handle = handle;
            Nome = nome;
            Valor = valor;
            CodigoAuxiliar = codigoAuxiliar;
            Estoque = estoque;
            Descricao = descricao;
            LogDataCadastro = logDataCadastro;
            LogDataAlteracao = logDataAlteracao;
            LogUsuarioCadastro = logUsuarioCadastro;
            LogUsuarioAlteracao = logUsuarioAlteracao;
        }
    }
}
