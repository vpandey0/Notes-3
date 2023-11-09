using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UserManagement_Security.Models;

namespace UserManagement_Security.Database
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("ConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
    
}