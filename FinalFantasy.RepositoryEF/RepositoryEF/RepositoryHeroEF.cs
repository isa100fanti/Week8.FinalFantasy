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
            using (var ctx = new ContextFinalFantasy())
            {
                
                    if (id != null)
                    {

                        return ctx.Heroes.Find(id);
                    }
                
             }
        }

        public bool CreateHero(Hero eroe)
        {
            bool esito = false;
            using (var ctx = new ContextFinalFantasy())
            {
                try
                {
                    if (eroe == null)
                    {
                        ctx.Entry<Hero>(eroe).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        ctx.SaveChanges();
                        esito = true;
                    }
                }
                catch (Exception ex)
                {
                    return esito;
                }
            }
            return esito;
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
