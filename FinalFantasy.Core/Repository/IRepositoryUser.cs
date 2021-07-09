using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryUser
    {
        public User Login(string nickname);
        public User Registrazione(User user);
        public IList<User> GetAll();
        //public User GetByNickname(string nickname);
        //public void Add(User user);
    }
}
