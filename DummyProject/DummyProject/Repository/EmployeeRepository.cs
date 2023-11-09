using DummyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyProject.Database;

namespace DummyProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeManagementContext  obj =new EmployeeManagementContext();
        int IEmployeeRepository.CreateEmployees(Employee emp)
        {
            obj.employees.Add(emp);  // it will add new record in local memory
            return obj.SaveChanges(); // will commit to database
          
        }

        Employee IEmployeeRepository.DeleteEmployees()
        {
            int i = 3;
            var e = obj.employees.Find(i);
            var t= obj.employees.Remove(e);
            obj.SaveChanges();
            return t;

        }

        ICollection<Employee> IEmployeeRepository.GetEmployees()
        {
            return obj.employees.ToList();
        }

        Employee IEmployeeRepository.SearchEmployees()
        {
            int i = 19;
            var t = obj.employees.Where(temp => temp.Id == i).FirstOrDefault();
            return t;

        }

        Employee IEmployeeRepository.UpdateEmployees()
        {
            string name = "Kanika";
            var e=obj.employees.Where(s => s.Name == name).FirstOrDefault();
            e.Name = "Jiya";
            obj.SaveChanges();
            return e;


        }
    }
}