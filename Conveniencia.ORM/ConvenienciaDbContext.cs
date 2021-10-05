using Conveniencia.Dominio.ClienteModule;
using Conveniencia.Dominio.ProdutoMarcadoModule;
using Conveniencia.Dominio.ProdutoModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveniencia.ORM
{
    public class ConvenienciaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoMarcado> ProdutosMarcados { get; set; }

        public ConvenienciaDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source=Banco.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConvenienciaDbContext).Assembly);
        }
    }
}
