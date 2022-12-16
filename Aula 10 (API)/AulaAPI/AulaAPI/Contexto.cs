using EntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings["EntityPostgresql"];
            string retorno = "";

            if (settings != null)
                retorno = settings.ConnectionString;

            optionsBuilder.UseNpgsql(retorno);

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
