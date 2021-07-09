using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum MonsterType
    {
        Lucifer,
        Ghost
    }
    public enum HeroType
    {
        Soldier,
        Wizard
    }

    public abstract class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string Classe { get; set; }
        public Weapon Weapon { get; set; }
        public int WeaponID { get; set; }
        public int Level { get; set; }
        public MonsterType TypeM { get; set; }
        public HeroType TypeH { get; set; }

        public virtual int Fight()
        {
            //METODO CHE IMPLEMENTA L'AGGIORNAMENTO DEI PUNTI 
            return 0;
            
        }
    }
}
