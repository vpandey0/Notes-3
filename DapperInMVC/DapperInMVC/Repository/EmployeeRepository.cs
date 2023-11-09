using DapperInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DapperInMVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static readonly string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con=new SqlConnection(conStr);
        int IEmployeeRepository.CreateEmployee(EmpViewModel emp)
        {
            try
            { 
                con.Open();
                int rowAffected=con.Execute("AddNewEmpDetails",emp,commandType:CommandType.StoredProcedure);
                con.Close();
                return rowAffected;


            }
            catch (Exception ex)
            {
                throw;
            }

        }

        int IEmployeeRepository.DeleteEmployee(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@eId", id);
                con.Open();
                int result=con.Execute("DeleteEmpById",param, commandType: CommandType.StoredProcedure);
                con.Close();
                return result;
            }
            catch (Exception )
            {
                    
                throw;
            }
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployeeDetail()
        {
            try
            {

                con.Open();
                List<Employee> result = SqlMapper.Query<Employee>(con, "GetEmployees").ToList();
                con.Close();
                return result;
            }
            catch (Exception )
            {
                throw;
            }
           
        }

        Employee IEmployeeRepository.SearchEmployee(int id)
        {
            try
            {
                //IEmployeeRepository e=new EmployeeRepository();
                //con.Open();
                //Employee result =e.GetEmployeeDetail().ToList().Where(m=>m.Id==id).FirstOrDefault
                //con.Close();
                //return result;
             
                con.Open();
                Employee result = SqlMapper.Query<Employee>(con, "SearchEmpById" , new {@eId=id} , commandType: CommandType.StoredProcedure).FirstOrDefault();
                con.Close();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        int IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            try
            {
              
                con.Open();
                int result=con.Execute("UpdateEmpDetails", employee, commandType: CommandType.StoredProcedure);
                con.Close();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}