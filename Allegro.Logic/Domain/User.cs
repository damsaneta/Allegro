using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Domain
{
    public class User
    {
        public User(string login, string firstName, string lastName)
        {
            this.Login = login;
            this.FirstName = firstName;
            this.LastName = lastName;

        }
        public int Id { get; set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        
        public string Login { get; private set; }


    }
}
