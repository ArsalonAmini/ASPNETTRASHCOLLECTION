using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Payment
    {

        public int ID { get; set; }

        public int CreditCardNumber { get; set; }

        public int ExpirationDate { get; set; }

    }
}