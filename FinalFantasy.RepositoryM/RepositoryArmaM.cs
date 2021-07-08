using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryM
{
    public class RepositoryArmaM 
    {
        //inserisco già delle armi,nel db e nel mock
        public ICollection<Arma> armi = new List<Arma>()
        {

            new Arma { NomeArma = "Mazza" },
            new Arma { NomeArma = "Spada" },
            new Arma { NomeArma = "Arco e frecce" },
            new Arma { NomeArma = "Bacchetta" },
            new Arma { NomeArma = "Bastone magico" },
            new Arma { NomeArma = "Arco" },
            new Arma { NomeArma = "Clava" },
            new Arma { NomeArma = "Divinazione" },
            new Arma { NomeArma = "Fulmine" },
            new Arma { NomeArma = "Tempesta" }
        };

    }
}
