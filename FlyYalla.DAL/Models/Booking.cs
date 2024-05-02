using System;
using FlyYalla.CU.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }

        [ForeignKey("Guest")]
        public string? GuestId { get; set; }

        [ForeignKey("FlightId")]
        public int? FlightId { get; set; }

        [ForeignKey("HotelId")]
        public int? HotelId { get; set; }

        public BookingType BookingType { get; set; }
        public BookAs BookAs { get; set; }

        public bool BookingStatus { get; set; }

        public DateTime? BookingDate { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public byte[]? ChildrenAges { get; set; }
        public int? NumRooms { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public virtual ApplicationUser? User { get; set; }
        public virtual GuestBooking? GuestBooking { get; set; }
        public virtual Flight? Flight { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public virtual ICollection<Cart>? InCarts { get; set; }

    }
}
