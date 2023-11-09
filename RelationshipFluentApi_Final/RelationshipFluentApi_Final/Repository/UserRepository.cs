using RelationshipFluentApi_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RelationshipFluentApi_Final.Database;

namespace RelationshipFluentApi_Final.Repository
{
    public class UserRepository : IUserRepository
    {
        UserManagementContext userDb=new UserManagementContext();
        public UserRepository() { }
       

        int IUserRepository.CreateUser(UserProfileViewModel user)
        {
            User u= new User();
            u.Name = user.Name;
            u.Email = user.Email;
            u.UserProfile = new Profile();
            u.UserProfile.ProfileName = user.ProfileName;
            u.UserProfile.Description = user.Description;
            userDb.Users.Add(u);
           return  userDb.SaveChanges();
        }

        int IUserRepository.DeleteUser(int id)
        {
            var e = userDb.Users.Where(m=>m.Id==id).FirstOrDefault();
            var e1 = userDb.Profiles.Where(m => m.Id == id).FirstOrDefault();
            userDb.Profiles.Remove(e1);
            userDb.Users.Remove(e);
            
            return userDb.SaveChanges();
            
        }

        IEnumerable<UserProfileViewModel> IUserRepository.GetUserDetail()
        {
            var result = from usr in userDb.Users
                         join pr in userDb.Profiles on usr.Id equals pr.Id into userJoin
                         from up in userJoin.DefaultIfEmpty()
                         select new UserProfileViewModel {Id=usr.Id, Name = usr.Name, Email = usr.Email, Description = up.Description, ProfileName = up.ProfileName };
            return result.ToList();
        }

        UserProfileViewModel IUserRepository.SearchUser(int id)
        {
            throw new NotImplementedException();

        }

        int IUserRepository.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}