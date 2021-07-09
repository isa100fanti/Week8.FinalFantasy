using System;
using System.Collections.Generic;
using Xunit;

namespace FinalFantasy.Test
{
    public class FightT
    {
        [Fact]
        public void FightT1()
        {
            //assert

            //act
            //arrange

            //ARRANGE
            FightTest fight = new FightTest();

            //ACT
            //var result = equation.ResolveSecondDegreeEquation(1, -3, 2);

            var result = new int[] {
                fight.HeroAttack(30, 15),
                fight.HeroAttack(10,10),
                fight.HeroAttack(8, 15)
                
            };

            Assert.Equal(15, result[0]);
            Assert.Equal(0, result[1]);

            Assert.Equal(0, result[2]);
            
    }
   }
}
