using api_filmes_senai.Domais;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Context
{
    public class Filmes_Context : DbContext
  {
    
   public Filmes_Context() {}
        public Filmes_Context(DbContextOptions<Filmes_Context> options): base (options) 
        {
        }

        public DbSet<Genero> Genero { get; set; }

        public DbSet<Filme> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
        { optionsBuilder.UseSqlServer("Server = DESKTOP-RLLR2QS\\SQLEXPRESS; Database = filmes; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
        base.OnConfiguring(optionsBuilder); }
        }
    }
}
