using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryGiocatore
    {
        public Giocatore Login(string nickname);
        public Giocatore Registrazione();

       
    }
}
