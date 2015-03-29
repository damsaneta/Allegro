using Allegro.Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        User GetByLogin(string login);
        void Delete(int id);
        void Update(User user);
        void Add(User user);  
    }
}
