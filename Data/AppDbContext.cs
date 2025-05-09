using ApiAula.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiAula.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) 
        { 
        }
        public DbSet<Produto> Produtos { get; set; }
        // Tabela virtualizada de produtos (Lista de produtos), que depois subirá para o banco de dados
    }
        
    }
