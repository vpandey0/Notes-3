using System;
using System.Collections.Generic;
using WebApplicationFinal.Models.ViewModel;
using WebApplicationFinal.Models;

namespace WebApplicationFinal.Repository
{
    public interface IStudentRepository
    {
        StudentViewModel Search(int id);
        IEnumerable<Student> GetStudentData();
        Student DeleteData(int id);
        Student UpdateData(Student stu);
        Student AddStudent(Student stu);

    }
}
