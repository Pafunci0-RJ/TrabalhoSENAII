using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Perfumes.Models;

namespace Perfumes.Data
{
    public class PerfumeContext : DbContext
    {
        public PerfumeContext(DbContextOptions<PerfumeContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("tbClientes");
            modelBuilder.Entity<Categoria>().ToTable("tbCategorias");
            modelBuilder.Entity<Produto>().ToTable("tbProdutos");
            modelBuilder.Entity<Venda>().ToTable("tbVendas");
            modelBuilder.Entity<Compra>().ToTable("tbCompras");

        }
    }
}
