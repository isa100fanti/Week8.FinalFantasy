using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryUserM : IRepositoryUser
    {
        public ICollection<User> users = new List<User>()
        {
            new User { Id = 1, Nickname = "pisi"},
            new User { Id = 2, Nickname = "gin88"}
        };

        public IList<User> GetAll()
        {
            return users.ToList();
        }

        public User Login(string nickname)
        {


            User g1 = null;
            foreach (var u in users)
            {
                if (nickname == u.Nickname)
                {

                    return g1;

                }
                else
                {

                    while (nickname != u.Nickname)
                    {
                        Console.WriteLine("nick errato! reinserisci nick");
                        nickname = Console.ReadLine();
                        if (nickname == u.Nickname)
                        {

                            return g1;

                        }
                    }

                }
            }
            return g1;
        }


        public User Registrazione(User user)
        {
            User user1 = null;
            Console.WriteLine("inserisci un nick");
            string nick = Console.ReadLine();
            foreach (var u in users)
            {
                if (u.Nickname != nick)
                {
                    user1 = new User() { Nickname = nick };
                    users.Add(user1);
                    Console.WriteLine("registrazione avvenuta con successo");
                }
            }
            return user1;

        }


    }



      
    
}
