using DependencyInversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Repository
{
    public interface IStudentRepository
    {
        Student AddStudentDetails();
    }
}
