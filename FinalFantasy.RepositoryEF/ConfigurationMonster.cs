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
    public class ConfigurationMonster : IEntityTypeConfiguration<Monster>
    {
        public void Configure(EntityTypeBuilder<Monster> builder)
        {
            builder.ToTable("Monsters");
            builder.HasKey(k => k.ID);
            builder.Property(r => r.Name).IsRequired();
            builder.Property(t => t.LifePoints).IsRequired();
            builder.Property(e => e.Level).IsRequired();
            builder.Property(a => a.TypeM).IsRequired();
            //tipo?
            builder.HasOne(s => s.Weapon)
                .WithMany(w => w.Monsters)
                .HasForeignKey(i => i.WeaponID); //FK


            builder.HasData(new Monster()
            {
                ID = 1,
                Level = 1,
                Name = "Lucifer XX",
                TypeM = MonsterType.Lucifer,
               
                
                
            },
            new Monster()
            {
                ID = 2,
                Level = 3,
                Name = "Lucifer V",
                TypeM = MonsterType.Lucifer,
               


            },
            new Monster()
            {
                ID = 3,
                Level = 4,
                Name = "Ophera Ghost",
                TypeM = MonsterType.Ghost,
                


            }
            );
        }
    }
}
