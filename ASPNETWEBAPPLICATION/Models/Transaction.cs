using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }

        public int Cost { get; set; }

        public int Date { get; set; }




    }
}