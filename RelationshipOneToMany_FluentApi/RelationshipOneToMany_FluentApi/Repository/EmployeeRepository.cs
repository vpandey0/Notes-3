using System;
using System.Collections.Generic;
using System.Linq;


namespace RelationshipOneToMany_FluentApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        int IEmployeeRepository.CreateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        int IEmployeeRepository.DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployeeDetail()
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeRepository.SearchEmployee(int id)
        {
            throw new NotImplementedException();
        }

        int IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}