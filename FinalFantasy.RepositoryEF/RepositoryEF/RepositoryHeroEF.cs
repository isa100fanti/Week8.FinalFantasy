using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.RepositoryEF
{
    public class RepositoryHeroEF : IRepositoryHero
    {
        public Hero ChooseHero(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateHero(Hero eroe)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            Hero heroDel = null;
            bool esito = false;
            using (var ctx = new ContextFinalFantasy())
            {
                if (id != null)
                {
                    ctx.Heroes.Find(id);
                }
            }
            using (var ctx = new ContextFinalFantasy())
            {
                if (heroDel != null)
                {
                    try
                    {
                        ctx.Entry<Hero>(heroDel).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        
                        ctx.SaveChanges();
                        esito = true;
                    }
                    catch (Exception ex)
                    {
                        return esito;
                    }
                }
            }
            return esito;
        }

        public IList<Hero> GetHeroesByUser(User user)
        {
            
            using(var ctx = new ContextFinalFantasy())
            {
                if (user != null)
                {
                   var result = ctx.Heroes.Where(k => k.User == user).ToList();
                    return result;
                }
            }
            
           
        }
    }
}
