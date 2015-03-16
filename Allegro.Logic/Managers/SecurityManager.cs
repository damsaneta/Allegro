using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Managers
{
    public class SecurityManager:ISecurityManager
    {
        public bool SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfUserExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
