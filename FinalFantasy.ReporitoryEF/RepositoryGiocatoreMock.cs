using System;
using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryGiocatoreMock : IRepositoryGiocatore
    {
        public List<Giocatore> GetAll()
        {
            return null; //IMPLEMENTAAAAAA
        }

        public Giocatore Login(string nickname)
        {
            Giocatore g1 = new Giocatore();
            
            if (nickname == g1.Nickname)
            {

                return g1;

            }
            else
            {
                Console.WriteLine("nick errato! reinserisci nick");
                g1 = null;
            }
            return g1;

        }

       
        public Giocatore Registrazione()
        {
            Giocatore g1 = new Giocatore();
            Console.WriteLine("inserisci un nick");
            string nick = Console.ReadLine();
            foreach (var n in GetAll())
            {
                if (n.Nickname != nick)
                {
                    g1.Nickname = nick;
                    GetAll().Add(g1);
                }
                
            }
            return g1;
        }




    }
}
