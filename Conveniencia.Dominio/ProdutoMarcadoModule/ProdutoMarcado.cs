using Conveniencia.Dominio.ClienteModule;
using Conveniencia.Dominio.ProdutoModule;
using Conveniencia.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.Dominio.ProdutoMarcadoModule
{
    public class ProdutoMarcado : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataMarcada { get; set; }

        public ProdutoMarcado()
        {
        }

        public ProdutoMarcado(Cliente cliente,
                              Produto produto,
                              int quantidade,
                              DateTime dataMarcada)
        {
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            DataMarcada = dataMarcada;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
