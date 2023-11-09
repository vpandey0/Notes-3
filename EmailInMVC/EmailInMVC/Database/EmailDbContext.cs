using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmailInMVC.Models;

namespace EmailInMVC.Database
{
    public class EmailDbContext:DbContext
    {
        public EmailDbContext():base("MyConnection")
        {

        }
        public DbSet<EmailModel> Emails { get; set; }
        public DbSet<User> Users { get; set; }

    }
}