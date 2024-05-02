using FlyYalla.CU.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int FlightNumber { get; set; }
        public string AirCraft { get; set; }       
        public int EconomyClassAvailable { get; set; }
        public int PremiumClassAvailable { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public FlightStatus Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }


    }
}
