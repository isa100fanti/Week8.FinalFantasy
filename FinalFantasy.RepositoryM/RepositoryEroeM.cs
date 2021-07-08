using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryEroeM : IRepositoryEroe
    {
        public int Attacco(Arma arma, int puntivita)
        {
            int attacco = 0;
            Arma a = new Arma();
            attacco = puntivita - a.PuntiDanno;
            return attacco;
        }

        public ICollection<Eroe> Eroi = new List<Eroe>()
        {
            new Eroe { Id = 1, PuntiEsp =20, Arma = {NomeArma = "Spada"}, idGiocatore = 1, Tipo = Eroe.TipoEroe.Soldier } 
        };

        public bool CreaEroe(Eroe eroe)
        {
            if (eroe != null)
            {
                Eroi.Add(eroe);
                return true;
            }
            else
            {
                return false;
            }
        }

     

        public void Fuga()
        {
            
        }
    }
}
