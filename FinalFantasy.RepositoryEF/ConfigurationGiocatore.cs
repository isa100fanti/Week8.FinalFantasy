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
    public class ConfigurationGiocatore : IEntityTypeConfiguration<Giocatore>
    {
        public void Configure(EntityTypeBuilder<Giocatore> builder)
        {
            builder.ToTable("Giocatori");
            builder.HasKey(k => k.Id);
            builder.Property("Nickname").IsRequired();
            builder.HasMany(w => w.Eroi)
                .WithOne(t => t.Giocatore)
                .HasForeignKey(i => i.idGiocatore);
        }
    }
}
