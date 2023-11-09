using System;
using System.Collections.Generic;
using System.Linq;
using PracticeMvc.Models;
using PracticeMvc.Database;


namespace PracticeMvc.Repository
{
    public class StudentRepo : IStudent
    {
        StudentContext stuC=new StudentContext();
        void IStudent.AddStudent(Student stu)
        {
            stuC.Students.Add(stu);
            stuC.SaveChanges();
           
        }

        Student IStudent.DeleteStudent(int Id)
        {
            var e = stuC.Students.Find(Id);
            var t = stuC.Students.Remove(e);
            stuC.SaveChanges();
            return t;
            
        }

        IEnumerable<Student> IStudent.GetAllStudents()
        {
            return stuC.Students.ToList();
        }

        Student IStudent.SearchStudent(int Id)
        {
            var t = stuC.Students.Where(m=>m.Id == Id).FirstOrDefault();
               
            return t;

        }

        Student IStudent.UpdateStudent(int id)
        {
            var e = stuC.Students.Where(s => s.Id==id).FirstOrDefault();
           
            stuC.SaveChanges();
            return e;

        }
    }
}