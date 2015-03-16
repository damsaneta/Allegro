using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Managers
{
    public class FakeSacurityManager : ISecurityManager
    {
        public bool SignIn(string username, string password)
        {
            return username == "aneta" && password == "kasza1";
        }

        public bool CheckIfUserExist(string username)
        {
            return username == "aneta";
        }
    }
}
