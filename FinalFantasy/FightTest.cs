using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class FightTest
    {
        public int HeroAttack(int life, int damage)
        {
            int result = 0;
            if(life > damage)
            {
                result = life - damage;
            }
            else if(life == damage)
            {
                result = 0;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
