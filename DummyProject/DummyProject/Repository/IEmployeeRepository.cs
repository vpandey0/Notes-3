using System;
using System.Collections.Generic;
using DummyProject.Models;

namespace DummyProject.Repository
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees(); // Done
        Employee SearchEmployees();
        int CreateEmployees(Employee emp); //Done
        Employee UpdateEmployees();
        Employee DeleteEmployees();


    }
}
