using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Worker
    {
        [Key]

        public int ID { get; set; }

        public string Name { get; set; }
    }
}