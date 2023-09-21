using Cad1.Models;
using Microsoft.EntityFrameworkCore;

namespace Cad1.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {

        }
         public DbSet<Setor> Setores {get; set;}
         public DbSet<Funcionario> Funcionarios {get; set;}
    }
}