using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationFinal_DFA.Models.ViewModel;

namespace WebApplicationFinal_DFA.Repository
{
    public interface IStudentRepository
    {
        StudentViewModel Search(int id);
        IEnumerable<Student> GetStudentData();
    }
}
