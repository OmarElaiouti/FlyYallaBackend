using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public decimal PricePerNight { get; set; }
        public int RoomsAvailable { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

    }
}
