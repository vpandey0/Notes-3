using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFinal_DFA.Models.ViewModel;

namespace WebApplicationFinal_DFA.Repository
{
    public class StudentRepository : IStudentRepository
    {
        StudentDBContext stuDb=new StudentDBContext();
        IEnumerable<Student> IStudentRepository.GetStudentData()
        {
            return stuDb.Students.ToList();
        }

        StudentViewModel IStudentRepository.Search(int id)
        {
            var temp = stuDb.Students.Where(m => m.Id == id)
                       .Select(m => new StudentViewModel
                       {
                           Id = m.Id,
                           Name = m.Name
                       }).FirstOrDefault();
            return temp;
        }
    }
}