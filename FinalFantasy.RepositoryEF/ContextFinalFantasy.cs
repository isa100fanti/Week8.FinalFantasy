using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class ContextFinalFantasy : DbContext
    {
        public DbSet<Eroe> Eroi { get; set; }
        public DbSet<Mostro> Mostri { get; set; }
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Arma> Armi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = FinalFantasy; Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Eroe>(new ConfigurationEroe());
            modelBuilder.ApplyConfiguration<Arma>(new ConfigurationArma());
            modelBuilder.ApplyConfiguration<Giocatore>(new ConfigurationGiocatore());
            modelBuilder.ApplyConfiguration<Mostro>(new ConfigurationMostro());
        }
    }
}
