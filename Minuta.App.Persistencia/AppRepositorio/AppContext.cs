using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public class AppContext : DbContext
    {
        public DbSet<DatosUser> DatosUsersDB{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Minuta.Frontend");
            }
        }
    }
}