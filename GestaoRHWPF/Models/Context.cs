

using Microsoft.EntityFrameworkCore;

namespace GestaoRHWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                    Database=GestaoRHWPF;
                    Trusted_Connection=true");
        }
    }
}
