using Conveniencia.Dominio.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.ORM.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TBCliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Cpf).IsRequired();
            builder.Property(x => x.Endereço).IsRequired();
            builder.Property(x => x.Telefone).IsRequired();
            builder.Property(x => x.Senha).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.CartaoAlimentacao);

            builder.Property(x => x.LimiteCredito).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.SaldoDevedor).IsRequired().HasDefaultValue(0);
        }
    }
}
