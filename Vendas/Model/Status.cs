using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    public static class Status
    {
        public const int Cadastrado = 1;
        public const int AgModificacao = 2;
        public const int Ativo = 3;
        public const int Cancelado = 4;
        public const int Encerrado = 5;
        public const int AgEntrega = 6;
    }
}
