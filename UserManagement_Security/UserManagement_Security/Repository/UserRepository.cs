using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManagement_Security.Models;
using UserManagement_Security.Database;

namespace UserManagement_Security.Repository
{
    public class UserRepository : IUserRepository
    {
        StudentDbContext stuDb=new StudentDbContext();
        int IUserRepository.CreateAccount(User user)
        {
           stuDb.Users.Add(user);
           return stuDb.SaveChanges();
        }

        bool IUserRepository.LoginValidate(string username, string password)
        {
            var result=stuDb.Users.Where(m => m.UserName == username && m.Password == password).FirstOrDefault();
            if(result==null)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }
    }
}