using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class ServiceWorker
    {
        [Key]

        public int ID { get; set; }

        [ForeignKey("Service")]
        public int ServiceID { get; set; }

        public Service Service { get; set; }


        [ForeignKey("Worker")]

        public int WorkerID { get; set; }

        public Worker Worker { get; set; }



    }
}