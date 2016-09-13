using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Schedule
    {

        [Key]

        public int ID { get; set; }

        public int Date { get; set; }


    }
}