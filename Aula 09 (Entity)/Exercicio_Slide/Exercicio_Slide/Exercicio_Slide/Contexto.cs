using EntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Slide
{
    internal class Contexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        public Contexto() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityPostgresql"];
            string retorno = "";

            if (settings != null)
                retorno = settings.ConnectionString;

            optionsBuilder.UseNpgsql(retorno);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasOne(conexao => conexao.aluno)
                .WithMany(conexao => conexao.Cursos)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
