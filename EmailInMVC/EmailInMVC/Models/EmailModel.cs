using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmailInMVC.Models
{
    public class EmailModel
    {
        [Key]
        public int Id { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        [NotMapped]
        public HttpPostedFileBase Attachment { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Created { get; set; }
    }
}
