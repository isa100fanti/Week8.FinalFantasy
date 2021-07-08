using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public class Eroe
    { 
        public enum TipoEroe
        {
            Soldier,
            Wizard
        }


        public int Livello { get 
            {
                int liv = 0;
                if (PuntiEsp == 0 || PuntiEsp < 30)
                   liv = 1;
                if (PuntiEsp > 29 || PuntiEsp < 60)
                    liv = 2;
                if (PuntiEsp > 59 || PuntiEsp < 90)
                    liv = 3;
                if (PuntiEsp > 89 || PuntiEsp < 120)
                    liv = 4;
                if (PuntiEsp > 119)
                    liv = 5;

                return liv;
            } }
        public int Id { get; set; }
        public int PuntiEsp { get; set; }
        public TipoEroe Tipo { get; set; }
        public Arma Arma { get; set; }  //nav property
        public int IdArma { get; set; } //FK
        public Giocatore Giocatore { get; set; }
        public int idGiocatore { get; set; }
        
        public int PuntiVita
        {
            get
            {
                int pvita = 0;
                switch (Livello)
                {
                    case 1:
                        pvita = 20;
                        break;
                    case 2:
                        pvita = 40;
                        break;
                    case 3:
                        pvita = 60;
                        break;
                    case 4:
                        pvita = 80;
                        break;

                }
                return pvita;
            }
        }

        public override string ToString()
        {
            return $"Livello: {Livello} Punti Vita: {PuntiVita} Punti Esperienza: {PuntiEsp}  ";
        }
    }
}
