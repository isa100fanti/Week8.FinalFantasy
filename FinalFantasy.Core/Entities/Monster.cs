﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    
    public class Monster : Character
    {


        public int LifePoints { get; set; }
        public override int Fight()
        {
            return Weapon.Damage;
        }


       
    }
}