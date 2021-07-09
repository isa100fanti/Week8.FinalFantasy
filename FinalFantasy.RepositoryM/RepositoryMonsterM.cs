using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryMonsterM : IRepositoryMonster
    {
        //ho gia dei mostri nel mock e nel db (Non ne creo di nuovi)
        public ICollection<Monster> monsters = new List<Monster>()
        {
            new Monster{ Level = 4, Name ="Lucifer XX", TypeM = MonsterType.Lucifer, Weapon = { Name = "Fulmine" }  },
            new Monster{ Level = 3, Name ="Lucifer V", TypeM = MonsterType.Lucifer, Weapon = { Name = "Divinazione" }  },
            new Monster{ Level = 2, Name ="Ghost K", TypeM = MonsterType.Ghost, Weapon = { Name = "Arco" }  },
            new Monster{ Level = 1, Name ="Ghost Y", TypeM = MonsterType.Ghost, Weapon = { Name = "Clava" }  },
            

        };

        public IList<Monster> GetMonsterByLevel(int levelNumber)
        {
            List<Monster> lista = new List<Monster>();
            foreach (var m in monsters)
            {
                if (m.Level == levelNumber)
                {
                    lista.Add(m);
                }
            }
            return lista;

        }
    }
}
