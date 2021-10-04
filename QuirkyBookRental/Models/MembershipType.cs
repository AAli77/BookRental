using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuirkyBookRental.Models
{
    public class MembershipType
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Sign Up Fee")]
        [Required]
        [DataType(DataType.Currency)]
        public byte SignUpFee { get; set; }

        [DisplayName("Rental Rate")]
        [Required]
        public Byte ChargeRateOneMonth { get; set; }  //for production always use double

        [DisplayName("Rate for SixMonths")]
        [Required]
        public Byte ChargeRateSixMonth { get; set; }  //for production always use double


    }
}