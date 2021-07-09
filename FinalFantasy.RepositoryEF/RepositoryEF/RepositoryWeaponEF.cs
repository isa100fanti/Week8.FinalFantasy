using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.RepositoryEF
{
    public class RepositoryWeaponEF : IRepositoryWeapon
    {
        public Weapon GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Weapon> GetWeaponsByClass(string tipology)
        {
            throw new NotImplementedException();
        }
    }
}
