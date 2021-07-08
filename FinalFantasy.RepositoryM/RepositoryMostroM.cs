using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryMostroM : IRepositoryMostro
    {
        //ho gia dei mostri nel mock e nel db (Non ne creo di nuovi)
        public ICollection<Mostro> mostri = new List<Mostro>()
        {
            new Mostro{ Livello = 1, Tipo = Mostro.TipoMostro.Ghost, Arma = {NomeArma = "Clava" }  },
            new Mostro{ Livello = 2, Tipo = Mostro.TipoMostro.Ghost, Arma = {NomeArma = "Clava" } },
            new Mostro{ Livello = 3, Tipo = Mostro.TipoMostro.Ghost, Arma = {NomeArma = "Arco" } },
            new Mostro{ Livello = 4, Tipo = Mostro.TipoMostro.Ghost, Arma = {NomeArma = "Arco" } },
            new Mostro{ Livello = 5, Tipo = Mostro.TipoMostro.Ghost, Arma = {NomeArma = "Arco" } },
            new Mostro{Livello = 1, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Tempesta" } },
            new Mostro{Livello = 2, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Tempesta" } },
            new Mostro{Livello = 3, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Fulmine" } },
            new Mostro{Livello = 4, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Fulmine" } },
            new Mostro{Livello = 4, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Tempesta" } },
            new Mostro{Livello = 4, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Divinazione" } },
            new Mostro{Livello = 5, Tipo = Mostro.TipoMostro.Lucifer, Arma = {NomeArma = "Divinazione" } }

        };

        public int Attacco(Arma arma, int puntivita)
        {
            throw new NotImplementedException();
        }
    }
}
