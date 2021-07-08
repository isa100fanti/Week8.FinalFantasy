using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public class Giocatore
    {
        public string Nickname { get; set; }
        
         public int Id { get; set; }
        public ICollection<Eroe> Eroi { get; set; } = new List<Eroe>(); 
       
    }



}
