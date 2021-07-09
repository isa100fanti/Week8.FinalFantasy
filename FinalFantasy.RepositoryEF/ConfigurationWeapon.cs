using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    public class ConfigurationWeapon : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapons");
            builder.HasKey(k => k.ID);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(r => r.Class).IsRequired();
            builder.Property(f => f.Damage).IsRequired();
            builder.HasData(new Weapon()
            
            {
                 Name = "Ascia",
                 Class = "Hero",
                 Damage = 8
                 
            },
            new Weapon()
            {
                Name = "Spada",
                Class = "Hero",
                Damage = 5
                
            },
            new Weapon()
            {
                Name = "Mazza",
                Class = "Hero",
                Damage = 10
                
            },
            new Weapon()
            {
                Name = "Arco",
                Damage = 7,
                Class = "Monster"
                
            },
             new Weapon()
             {
                 Name = "Clava",
                 Damage = 5,
                 Class = "Monster"

             },
             new Weapon()
             {
                 Name = "Tempesta",
                 Damage = 8,
                 Class = "Monster"

             },
             new Weapon()
             {
                 Name = "Divinazione",
                 Damage = 5,
                 Class = "Monster"

             },
             new Weapon()
             {
                 Name = "Bacchetta",
                 Damage = 5,
                 Class = "Hero"

             }

            );
        }
    }
}
