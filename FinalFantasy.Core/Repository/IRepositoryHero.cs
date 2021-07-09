using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryHero 
    {
        public bool CreateHero(Hero eroe); //void?

        public Hero ChooseHero(int id);  
        public bool Delete(int id);
        public IList<Hero> GetHeroesByUser(User user);
        
        
        
    }
}
