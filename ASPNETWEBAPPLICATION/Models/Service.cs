using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Service
    {
        [Key]

        public int ID { get; set; }

        public string Name { get; set; }



    }
}