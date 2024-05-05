using FlyYalla.CU.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class GuestBooking
    {
        public int GuestBookingId { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? DocumentNumber { get; set; }
        public DocumentType? DocumentType { get; set; }
        public DateTime? DocumentExpiryDate { get; set; }
        public DateTime? DocumentIssuingCountry { get; set; }

        public int BookingId { get; set; } // Foreign key to Booking

        [ForeignKey("BookingId")] public virtual Booking? Booking { get; set; }

    }
}
