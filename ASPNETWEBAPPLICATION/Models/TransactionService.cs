using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class TransactionService
    {

        [Key]
        public int ID { get; set; }

        [ForeignKey("Transaction")]

        public int Transaction { get; set; }

        public Transaction transaction { get; set; }

        [ForeignKey("Service")]

        public int ServiceID { get; set; }

        public Service Service { get; set; }





    }
}