using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    
    public class Arma
    {
        public int Id { get; set; }
        public int PuntiDanno { get { return DannoArma(); } }
        public string NomeArma { get; set; }
        //quanti punti tolgo dipende dall'arma
        //abbini a un eroe l'arma

        //le armi le ho tutte nel db
        //metodo per detrazione punti
        public Eroe Eroe { get; set; }
        public Mostro Mostro { get; set; }
        public int DannoArma()
        {
            int danno = 0;
            switch(NomeArma)
            {
                case "Ascia":
                    danno = 8;
                    break;
                case "Mazza":
                    danno = 5;
                    break;
                case "Spada":
                    danno = 10;
                    break;
                case "":
                    danno = 5;
                    break;
                case "Arco e Frecce":
                    danno = 8;
                    break;
                case "Bacchetta":
                    danno = 5;
                    break;
                case "Bastone Magico":
                    danno = 10;
                    break;
                case "Arco":
                    danno = 7;
                    break;
                case "Clava":
                    danno = 5;
                    break;
                case "Divinazione":
                    danno = 15;
                    break;
                case "Fulmine":
                    danno = 10;
                    break;
                case "Tempesta":
                    danno = 8;
                    break;

            }
            return danno;
        }
    }
}
