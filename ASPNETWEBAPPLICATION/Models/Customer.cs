using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Customer
    {
        [Key]

        
        public int ID { get; set; }

        
        public string Name { get; set; }

        public int DOB { get; set; }

        public string Email { get; set; }

        


    }
}