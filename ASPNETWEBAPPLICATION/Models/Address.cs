using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETWEBAPPLICATION.Models
{
    public class Address
    {
        [Key]

        public int ID { get; set; }

        [ForeignKey("Street")]

        public int Street { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }

        public City City { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }

        public Country Country { get; set; }
    }
}