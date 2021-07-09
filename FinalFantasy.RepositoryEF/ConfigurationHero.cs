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
    public class ConfigurationHero : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.ToTable("Heroes");
            builder.HasKey(k => k.ID);
            builder.Property(a => a.Name).IsRequired();

            builder.Property(e => e.Level).IsRequired();
            builder.Property(w => w.LifePoints).IsRequired();
            builder.Property(y => y.TypeH).IsRequired();

            builder.HasOne(d => d.Weapon)
                .WithMany(g => g.Heroes)
                .HasForeignKey(a => a.WeaponID);  //collegam weapon

            builder.HasOne(q => q.User)
                .WithMany(g => g.Heroes)  //collegam user
                .HasForeignKey(i => i.UserId);
        }
    }
}
