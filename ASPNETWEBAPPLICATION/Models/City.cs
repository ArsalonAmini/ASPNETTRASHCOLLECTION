using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPNETWEBAPPLICATION.Models
{
    public class City
    {
        [Key]

        public int ID { get; set; }

        public string Name { get; set; }

    }
}