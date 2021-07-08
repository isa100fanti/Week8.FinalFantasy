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
    public class ConfigurationEroe : IEntityTypeConfiguration<Eroe>
    {
        public void Configure(EntityTypeBuilder<Eroe> builder)
        {
            builder.ToTable("Eroi");
            builder.HasKey(k => k.Id);
            builder.Property(e => e.Livello).IsRequired();
            builder.Property(w => w.PuntiEsp).IsRequired();
            builder.Property(a => a.PuntiVita).IsRequired();
            builder.HasOne(d => d.Arma)
                .WithOne(g => g.Eroe);
        }
    }
}
