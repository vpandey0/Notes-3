using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Security.Models;

namespace UserManagement_Security.Repository
{
    public interface IUserRepository
    {
        
        int CreateAccount(User user);
        bool LoginValidate(string username, string password);
    }
}
