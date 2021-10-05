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
    public static class Exemplos
    {

        public static void CriarCliente()
        {
            using var db = new ConvenienciaDbContext();

            Cliente c = new(
                "Joao",
                "123.321.321.321",
                "R. Lages",
                "(99) 9 9999-9999",
                "123",
                "teste@test.com",
                100,
                "",
                0);

            db.Clientes.Add(c);

            db.SaveChanges();
        }

        public static void EditarCliente()
        {
            using var db = new ConvenienciaDbContext();

            Cliente c = new(
                "Joao",
                "123.321.321.321",
                "R. Lages",
                "(99) 9 9999-9999",
                "123",
                "teste@test.com",
                100,
                "",
                0);

            db.Clientes.Add(c);

            db.SaveChanges();
            //-----------------


            Cliente encontrado = db.Clientes
                .Where(x => x.Id == c.Id)
                .First();

            encontrado.Nome = "José";

            db.Clientes.Update(encontrado);

            db.SaveChanges();
        }

        public static void ExcluirCliente()
        {
            using var db = new ConvenienciaDbContext();

            Cliente c = new(
                "Joao",
                "123.321.321.321",
                "R. Lages",
                "(99) 9 9999-9999",
                "123",
                "teste@test.com",
                100,
                "",
                0);

            db.Clientes.Add(c);

            db.SaveChanges();

            // -----------

            Cliente encontrado = db.Clientes
                .Where(x => x.Id == c.Id)
                .First();

            db.Clientes.Remove(encontrado);

            db.SaveChanges();
        }


        public static void CriarProduto()
        {
            using var db = new ConvenienciaDbContext();

            Produto p = new("Batata", 1.50, 2.00, 10);

            db.Produtos.Add(p);

            db.SaveChanges();
        }

        public static void CriarProdutoEMarcar()
        {
            using var db = new ConvenienciaDbContext();

            Produto p = new("Batata", 1.50, 2.00, 10);

            Cliente c = new(
                "Joao",
                "123.321.321.321",
                "R. Lages",
                "(99) 9 9999-9999",
                "123",
                "teste@test.com",
                100,
                "",
                0);

            //adiciona varios de uma vez
            /*
             Poderia ser tambem:
                db.Add(p);
                db.Add(c);

                ou  

                db.Clientes.Add(c);
                db.Produtos.Add(p);
             */
            db.AddRange(p, c);

            db.SaveChanges();

            //------

            ProdutoMarcado pm = new(c, p, 1, DateTime.Now);

            db.ProdutosMarcados.Add(pm);

            db.SaveChanges();

            //-------

            //Pega os produtos marcados de um cliente

            Cliente encontrado = db.Clientes
                .Include(x => x.ProdutosMarcados) //Marcar para incluir os produtosMarcados
                .Where(x => x.Id == c.Id)
                .First();

            var produtosMarcados = encontrado.ProdutosMarcados;
        }

        public static void CriarProdutoEMarcarOutraForma()
        {
            using var db = new ConvenienciaDbContext();

            Produto p = new("Batata", 1.50, 2.00, 10);

            Cliente c = new(
                "Joao",
                "123.321.321.321",
                "R. Lages",
                "(99) 9 9999-9999",
                "123",
                "teste@test.com",
                100,
                "",
                0);

            //apenas inicializa a list pq aqui ela está como Null
            c.ProdutosMarcados = new();

            //Se adicionar algo aqui na lista ele já entende que é pra inserir um ProdutoMarcado no DB
            c.ProdutosMarcados.Add(
                new ProdutoMarcado(c, p, 1, DateTime.Now)
            );

            c.ProdutosMarcados.Add(
                new ProdutoMarcado(c, p, 2, DateTime.Now.AddDays(-7))
            );

            db.AddRange(p, c);

            db.SaveChanges();

            //-------

            //Pega os produtos marcados de um cliente

            Cliente encontrado = db.Clientes
                .Include(x => x.ProdutosMarcados) //Marcar para incluir os produtosMarcados
                .Where(x => x.Id == c.Id)
                .First();

            var produtosMarcados = encontrado.ProdutosMarcados;
        }
    }
}
