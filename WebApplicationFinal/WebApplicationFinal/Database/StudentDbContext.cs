using System;
using System.Data.Entity;
using WebApplicationFinal.Models;

namespace WebApplicationFinal.Database
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("ConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }  //Students will be actual table name in Database

    }
    
}