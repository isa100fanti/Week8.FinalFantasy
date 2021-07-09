using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum ArmaMostro
    {
        Arco,
        Clava,
        Divinazione,
        Fulmine,
        Tempesta
    }

    public enum ArmaEroe
    {
        Spada,
        Ascia,
        Mazza,
        ArcoEfrecce,
        bastoneMagico,
        BAcchetta

    }
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Damage { get; set; }

        public string Class { get; set; }


        public ICollection<Monster> Monsters { get; set; } = new List<Monster>();  //collegamento con Monster
        public ICollection<Hero> Heroes { get; set; } = new List<Hero>();  //collegamento con Hero
        public override string ToString()
        {
            return $"{ID} - {Name} - Punti danno {Damage}";
        } 

            //switch(NomeArma)
            //{
            //    case "Ascia":
            //        danno = 8;
            //        break;
            //    case "Mazza":
            //        danno = 5;
            //        break;
            //    case "Spada":
            //        danno = 10;
            //        break;
            //    case "":
            //        danno = 5;
            //        break;
            //    case "Arco e Frecce":
            //        danno = 8;
            //        break;
            //    case "Bacchetta":
            //        danno = 5;
            //        break;
            //    case "Bastone Magico":
            //        danno = 10;
            //        break;
            //    case "Arco":
            //        danno = 7;
            //        break;
            //    case "Clava":
            //        danno = 5;
            //        break;
            //    case "Divinazione":
            //        danno = 15;
            //        break;
            //    case "Fulmine":
            //        danno = 10;
            //        break;
            //    case "Tempesta":
            //        danno = 8;
            //        break;

            //}
         
    }
}
