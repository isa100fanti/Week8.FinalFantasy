using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.RepositoryEF
{
    public class RepositoryMonsterEF : IRepositoryMonster
    {
        public IList<Monster> GetMonsterByLevel(int levelNumber)
        {
            throw new NotImplementedException();
        }
    }
}
