using DapperInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperInMVC.Repository
{
    public interface IEmployeeRepository
    {
        int CreateEmployee(EmpViewModel emp);
        IEnumerable<Employee> GetEmployeeDetail();
        Employee SearchEmployee(int id);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
