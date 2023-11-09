using DependencyInversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Repository
{
    public class StudentRepository : IStudentRepository
    {
        Student IStudentRepository.AddStudentDetails()
        {
            Student student = new Student();
            student.Id = 1;
            student.Name= "Test";
            return student;
        }
    }
}