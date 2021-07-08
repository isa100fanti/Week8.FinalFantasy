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
    public class ConfigurationMostro : IEntityTypeConfiguration<Mostro>
    {
        public void Configure(EntityTypeBuilder<Mostro> builder)
        {
            builder.ToTable("Mostri");
            builder.HasKey(k => k.Id);
            builder.Property(e => e.Livello).IsRequired();
            builder.Property(r => r.PuntiVita).IsRequired();
            builder.Property(w => w.Tipo).IsRequired();
            builder.HasOne(s => s.Arma)
                .WithOne(q => q.Mostro); //non so come mettere la FK


            //builder.HasData(new Mostro()
            //{
            //    Id = 1,
            //    Livello = 1,
            //    Tipo = Mostro.TipoMostro.Ghost,
            //    Arma = { NomeArma = "Clava" }
            //},
            //new Mostro()
            //{ Id = 2,
            //    Livello = 2,
            //    Tipo = Mostro.TipoMostro.Ghost,
            //    Arma = { NomeArma = "Clava" }
            //},
            //new Mostro()
            //{
            //    Id = 3,
            //    Livello = 3,
            //    Tipo = Mostro.TipoMostro.Ghost,
            //    Arma = { NomeArma = "Arco" }
            //},
            //new Mostro()
            //{
            //    Id = 4,
            //    Livello = 1,
            //    Tipo = Mostro.TipoMostro.Lucifer,
            //    Arma = { NomeArma = "Tempesta" }
            //}
            //);
        }
    }
}
