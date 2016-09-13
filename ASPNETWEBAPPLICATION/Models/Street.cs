using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace ASPNETWEBAPPLICATION.Models
{
    public class Street
    {
        [Key]

        public int ID { get; set; }

        public string StreetAddress { get; set; }
    }
}