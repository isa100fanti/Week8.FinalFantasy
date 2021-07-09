using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryWeaponM : IRepositoryWeapon
    {
        //inserisco già delle armi,nel db e nel mock
        public ICollection<Weapon> weapons = new List<Weapon>()
        {

            new Weapon { Name = "Mazza", ID = 1, Class = "Hero", Damage = 5},
            new Weapon { Name = "Ascia", ID = 2, Class = "Hero", Damage = 10},
            new Weapon { Name = "Spada" ,ID = 3, Class = "Hero", Damage = 8},
            new Weapon { Name = "Arco e frecce",ID = 4, Class = "Hero", Damage = 8 },
            new Weapon { Name = "Bacchetta",ID = 5, Class = "Hero", Damage = 5 },
            new Weapon { Name = "Bastone magico",ID = 6, Class = "Hero", Damage = 10 }, // hero fin qui
            new Weapon { Name = "Arco",ID = 7, Class = "Monster", Damage = 7 },  //mostri
            new Weapon { Name = "Clava" ,ID = 8, Class = "Monster", Damage = 5},
            new Weapon { Name = "Divinazione" ,ID = 9, Class = "Monster", Damage = 15},
            new Weapon { Name = "Fulmine" ,ID = 10, Class = "Monster", Damage = 10},
            new Weapon { Name = "Tempesta" ,ID = 11, Class = "Monster", Damage = 8},
            new Weapon { Name = "Tempesta Oscura" ,ID = 12, Class = "Monster", Damage = 15},
        };

        public Weapon GetById(int id)
        {
            return weapons.FirstOrDefault(w => w.ID == id);

        }

        public IList<Weapon> GetWeaponsByClass(string tipology)
        {
            return weapons.Where(w => w.Class == tipology).ToList();

        }
    }
}
