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
    public class ConfigurationArma : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("Armi");
            builder.HasKey(k => k.Id);
            builder.Property(e => e.NomeArma).IsRequired();
            builder.Property(r => r.PuntiDanno).IsRequired();
            builder.HasOne(f => f.Mostro)
                .WithOne(h => h.Arma);
            builder.HasData(new Arma()
            {
                Id = 1,
                 NomeArma = "Ascia"
                 
            },
            new Arma()
            {
                Id = 2,
                NomeArma = "Spada"
            },
            new Arma()
            {
                Id = 3,
                NomeArma = "Mazza"
            },
            new Arma()
            {
                Id = 4,
                NomeArma = "Arco"
            }
            );
        }
    }
}
