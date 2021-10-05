using Conveniencia.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.Dominio.ClienteModule
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }

        //TODO: hashar essa senha antes de usar
        public string Senha { get; set; }
        public string Email { get; set; }
        public double LimiteCredito { get; set; }
        public string CartaoAlimentacao { get; set; }
        public double SaldoDevedor { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome,
                       string cpf,
                       string endereço,
                       string telefone,
                       string senha,
                       string email,
                       double limiteCredito,
                       string cartaoAlimentacao,
                       double saldoDevedor)
        {
            Nome = nome;
            Cpf = cpf;
            Endereço = endereço;
            Telefone = telefone;
            Senha = senha;
            Email = email;
            LimiteCredito = limiteCredito;
            CartaoAlimentacao = cartaoAlimentacao;
            SaldoDevedor = saldoDevedor;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
