using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace PracticeMvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Name does not contain Numbers")]
        public string Name { get; set;}
        [Range(18, 25)]
        public int Age { get; set;}
        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Entered Roll Number is not valid.")]
        public int RollNo {  get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Eamil")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
            ErrorMessage = "Please Provide Valid Email")]
        public string Email {  get; set;}
        public string Branch { get; set;}
        public string Gender{ get; set;}

    }
   
}