using System;
using RelationshipFluentApi_Final.Models;
using System.Data.Entity;

namespace RelationshipFluentApi_Final.Database
{
    public class UserManagementContext:DbContext
    {
        public UserManagementContext():base("ConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }  
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
      


            // Configure ID as PK for StudentLogIn
            modelBuilder.Entity<User>().HasKey(s=>s.Id);
        
            // Configure ID as FK for StudentLogIn
            modelBuilder.Entity<Profile>().HasRequired(r=>r.user).WithOptional(s=>s.UserProfile);
        }


    }
}