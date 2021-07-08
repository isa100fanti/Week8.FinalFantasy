using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryGiocatoreM : IRepositoryGiocatore
    {
        public ICollection<Giocatore> ListaUtenti = new List<Giocatore>()
        {
            new Giocatore { Nickname = "pisi"}
        };

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
                
            
            return g1;
        }

    }
}
