using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleTablesFinal.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Location{ get; set; }
        public string City { get; set; }
        public Customer Cust { get; set; }
    }
}