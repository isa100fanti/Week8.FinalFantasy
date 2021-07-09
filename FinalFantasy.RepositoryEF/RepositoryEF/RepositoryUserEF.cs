using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.RepositoryEF
{
    public class RepositoryUserEF : IRepositoryUser
    {
        public IList<User> GetAll()
        {
            using (var ctx = new ContextFinalFantasy())
            {
                return ctx.Users.ToList();
            }
        }

        public User Login(string nickname)
        {
            using (var ctx = new ContextFinalFantasy())
            {
             
                    var user = ctx.Users.Find(nickname);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    Console.WriteLine("nickname non corretto!");
                    return null;
                }
            }

            

        }

        public User Registrazione(User user)
        {

            string nickname="";
            using (var ctx = new ContextFinalFantasy())
            {
                if (user != null)
                {
                    if ((nickname != null) && (ctx.Users.Find(nickname) == null))
                    {
                        ctx.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        ctx.SaveChanges();
                    }
                                      

                }
            }
            return user;

           
            
        }
    }
}
