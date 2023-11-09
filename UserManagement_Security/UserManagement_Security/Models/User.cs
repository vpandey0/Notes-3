using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement_Security.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}