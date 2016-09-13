using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class ScheduleService
    {
        [Key]

        public int ID { get; set; }

        [ForeignKey("Schedule")]

        public int ScheduleID { get; set; }

        public Schedule Schedule { get; set; }

        [ForeignKey("Service")]

        public int ServiceID { get; set; }

        public Service Service { get; set; }



    }
}