using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizAndSurvey.Models
{
    public class AssignmentTable
    {
        public int As_Id {  get; set; }
       public string As_Name { get; set; }
        public string As_Category { get; set;}
        public string As_Difficulty { get; set;}
        public int UserId {  get; set; }
        public string UserName { get; set; }    
   
    }
}