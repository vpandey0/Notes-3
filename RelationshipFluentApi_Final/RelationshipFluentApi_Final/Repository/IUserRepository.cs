using System;
using System.Collections;
using RelationshipFluentApi_Final.Models;
using System.Collections.Generic;


namespace RelationshipFluentApi_Final.Repository
{
    public interface IUserRepository
    {
         int CreateUser(UserProfileViewModel user); // Done
         IEnumerable<UserProfileViewModel> GetUserDetail();
         UserProfileViewModel SearchUser(int id);
         int UpdateUser(User user);
         int DeleteUser(int id);


    }
}
