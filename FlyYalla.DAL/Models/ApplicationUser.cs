using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class ApplicationUser: IdentityUser
    {
        // Passenger and Passport details
        public bool IsEmailConfirmed { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public DateTime? PassportCountry { get; set; }

        [ForeignKey("Cart")]
        public int? CartId { get; set; }

        // Additional registration details
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }


    }
}
