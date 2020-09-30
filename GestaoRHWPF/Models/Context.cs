

using Microsoft.EntityFrameworkCore;

namespace GestaoRHWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Caixa> Caixas { get; set; }

        public DbSet<Prontuario> Prontuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                    Database=GestaoRHWPF;
                    Trusted_Connection=true");
        }
    }
}
