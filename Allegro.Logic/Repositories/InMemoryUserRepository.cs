using Allegro.Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Repositories
{
    public class InMemoryUserRepository: IUserRepository
    {
        private static int count = 2;
        private static readonly List<User> users = new List<User> 
        { 
            new User("Aneta", "Aneta","Dams"){Id=1},
            new User("Lukasz", "Łukasz", "Dams"){Id=2}
        }; 
        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByLogin(string login)
        {
            foreach(var u in users)
            {
                if(u.Login==login)
                {
                    return u;
                }
                
            }
            return null;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            count++;
            user.Id = count;
            users.Add(user);
        }
    }
}
