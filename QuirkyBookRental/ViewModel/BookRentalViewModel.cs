using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using QuirkyBookRental.Models;
using QuirkyBookRental.Utility;
using static QuirkyBookRental.Models.BookRent;

namespace QuirkyBookRental.ViewModel
{
    public class BookRentalViewModel
    {
        //Book Details
        public int Id { get; set; }
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Range(0, 1000)]
        [DisplayName("Availability")]
        public int Availbility { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? DateAdded { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        [DisplayName("Publication Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime PublicationDate { get; set; }
        [DisplayName("Pages")]
        public int Pages { get; set; }
        [DisplayName("Product Dimension")]
        public int ProductDimensions { get; set; }
        public string Publisher { get; set; }

        //Rental Details
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Actual End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? ActualEndDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        [DisplayName("Schedule End Date")]
        public DateTime? ScheduleEndDate { get; set; }
        public string RentalDuration { get; set; }
        [DisplayName("Additional Charges")]
        public double? AdditionalCharge { get; set; }
        [DisplayName("Rental Price")]
        public double RentalPrice { get; set; }
        public string Status { get; set; }

        [DisplayName("Rental Price for 1Month")]
        public double rentalPriceOneMonth { get; set; }
        [DisplayName("Rental Price for 6Months")]
        public double rentalPriceSixMonth { get; set; }

        //User Details
        public string UserId { get; set; }
        public string Email { get; set; }

        [DisplayName("BirthDay")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Name
        {
            get { return FirstName + " " + LastName; }
        }

        public string actionName
        {
            get
            {
                if (Status.ToLower().Contains(SD.RequestedLower))
                {
                    return "Approve";
                }
                if (Status.ToLower().Contains(SD.ApprovedLower))
                {
                    return "Pickup";
                }
                if (Status.ToLower().Contains(SD.RentedLower))
                {
                    return "Return";
                }

                return null;
            }
        }

    }
}