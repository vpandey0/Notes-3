using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeMvc.Models;

namespace PracticeMvc.Repository
{
    public interface IStudent
    {
        void AddStudent(Student stu);
        Student UpdateStudent(int Id);
        Student DeleteStudent(int Id);
        Student SearchStudent(int Id);
        IEnumerable<Student> GetAllStudents();
    }
}
