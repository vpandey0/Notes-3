using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFinal.Models;
using WebApplicationFinal.Models.ViewModel;
using WebApplicationFinal.Database;

namespace WebApplicationFinal.Repository
{
    public class StudentRepository : IStudentRepository
    {
        StudentDbContext stuC=new StudentDbContext();

        Student IStudentRepository.AddStudent(Student stu)
        {
           var t= stuC.Students.Add(stu);
            stuC.SaveChanges();
            return t;
        }

        Student IStudentRepository.DeleteData(int id)
        {
            var e = stuC.Students.Find(id);
            var t = stuC.Students.Remove(e);
            stuC.SaveChanges();
            return t;

        }

        IEnumerable<Student> IStudentRepository.GetStudentData()
        {
            return stuC.Students.ToList();
        }

        StudentViewModel IStudentRepository.Search(int id)
        {
            //Applying Projection Query to fetch the view Column and giving to ViewModel knowns as DTO
            var temp=stuC.Students.Where(m=> m.Id==id)
                        .Select(m => new StudentViewModel
                        {
                            Id = m.Id,
                            Name = m.Name
                        }).FirstOrDefault();
            return temp;

        }

        Student IStudentRepository.UpdateData(Student stu)
        {
            var e = stuC.Students.Find(stu.Id);
            e.Name = stu.Name;
            e.Address = stu.Address;
            e.Age = stu.Age;
            stuC.SaveChanges();
            return e;

        }
    }
}