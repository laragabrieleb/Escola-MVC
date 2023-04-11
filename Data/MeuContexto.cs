using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EscolaMVC.Data
{
    public class MeuContexto : DbContext
    {
        private readonly IConfiguration configuration;

        public MeuContexto(DbContextOptions<MeuContexto> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Turma> Turma { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(Aluno).Assembly);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = this.configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder.UseSqlServer(connectionstring);

            base.OnConfiguring(optionsBuilder);
        }
    }

    
}
