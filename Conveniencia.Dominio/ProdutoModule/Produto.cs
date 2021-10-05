using Conveniencia.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.Dominio.ProdutoModule
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }

        public int Estoque { get; set; }

        public Produto()
        {
        }

        public Produto(string nome,
                       double precoCompra,
                       double precoVenda,
                       int estoque)
        {
            Nome = nome;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            Estoque = estoque;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
