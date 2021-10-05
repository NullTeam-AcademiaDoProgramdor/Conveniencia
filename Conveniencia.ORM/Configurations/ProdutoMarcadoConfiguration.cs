using Conveniencia.Dominio.ProdutoMarcadoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.ORM.Configurations
{
    public class ProdutoMarcadoConfiguration : IEntityTypeConfiguration<ProdutoMarcado>
    {
        public void Configure(EntityTypeBuilder<ProdutoMarcado> builder)
        {
            builder.ToTable("TBProdutoMarcado");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.DataMarcada).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.Produto);
            builder
                .HasOne(x => x.Cliente)
                .WithMany(x => x.ProdutosMarcados);

        }
    }
}
