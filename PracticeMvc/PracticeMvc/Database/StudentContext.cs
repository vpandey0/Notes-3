using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PracticeMvc.Models;

namespace PracticeMvc.Database
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("MyConnection") 
        { 

        }
        public DbSet<Student> Students { get; set; }
    }
}