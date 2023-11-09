using System;
using System.Collections.Generic;


namespace RelationshipOneToMany_FluentApi.Repository
{
    public interface IEmployeeRepository
    {
        int CreateEmployee(Employee emp);
        IEnumerable<Employee> GetEmployeeDetail();
        Employee SearchEmployee(int id);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
