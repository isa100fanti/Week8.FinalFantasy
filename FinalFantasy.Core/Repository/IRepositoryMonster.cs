using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryMonster
    {
        public IList<Monster> GetMonsterByLevel(int levelNumber);

    }
}
