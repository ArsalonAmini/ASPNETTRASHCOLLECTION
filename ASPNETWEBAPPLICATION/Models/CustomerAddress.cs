using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class CustomerAddress
    {
        [Key]

        public int ID { get; set; }

        [ForeignKey("Address")]

        public int AddressID { get; set; }

        public Address Address { get; set; }

        [ForeignKey("Customer")]

        public int CustomerID {get;set;}

        public Customer Customer { get; set; }


    }
}