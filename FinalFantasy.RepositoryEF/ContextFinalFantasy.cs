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
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = FinalFantasy; Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Hero>(new ConfigurationHero());
            modelBuilder.ApplyConfiguration<Weapon>(new ConfigurationWeapon());
            modelBuilder.ApplyConfiguration<User>(new ConfigurationUser());
            modelBuilder.ApplyConfiguration<Monster>(new ConfigurationMonster());
        }
    }
}
