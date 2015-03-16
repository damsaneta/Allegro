using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegro.Logic.Managers
{
    public interface ISecurityManager
    {
        bool SignIn(string username, string password);

        bool CheckIfUserExist(string username);
    }
}
