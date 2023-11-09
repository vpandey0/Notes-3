using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using DummyProject.Models;

namespace DummyProject.Database
{
    public class EmployeeManagementContext: DbContext
    {
        public EmployeeManagementContext():base("MyConnection")
        {

        }
        public DbSet<Employee> employees { get; set; }  // employees is an obj of DbSet class


    }
}