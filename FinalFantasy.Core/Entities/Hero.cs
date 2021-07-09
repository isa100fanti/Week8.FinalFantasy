using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    
    public class Hero : Character
    { 
        

        //public int Livello { get 
        //    {
        //        int liv = 0;
        //        if (PuntiEsp == 0 || PuntiEsp < 30)
        //           liv = 1;
        //        if (PuntiEsp > 29 || PuntiEsp < 60)
        //            liv = 2;
        //        if (PuntiEsp > 59 || PuntiEsp < 90)
        //            liv = 3;
        //        if (PuntiEsp > 89 || PuntiEsp < 120)
        //            liv = 4;
        //        if (PuntiEsp > 119)
        //            liv = 5;

        //        return liv;
        //    } }
        public int LifePoints { get; set; }
        public int ExperiencePoint { get; set; }

        public User User { get; set; } //nav proprerty
        public int UserId { get; set; } //FK
        public override int Fight()
        {
            return Weapon.Damage;
        }


        public bool Escape()
        {
            Random fuga = new Random();
            int possibilita = fuga.Next(0, 3);  //dovrebbe prendere i valori di 1 e 2
            if (possibilita == 1)
            {
                Console.WriteLine("fuga riuscita!");
                return true;
            }
            else
            {
                return false;
            }

        }


       
    }
}
