using FlyYalla.CU.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Models
{
    public class SupportTicket
    {
        [Key]
        public int TicketId { get; set; }
        public string UserId { get; set; } // User who submitted the ticket
        public string IssueDescription { get; set; }
        public DateTime DateSubmitted { get; set; }
        public SupportTicketStatus Status { get; set; } // Enum representing ticket status (e.g., Open, In Progress, Closed)

        // Navigation property
        public virtual ApplicationUser User { get; set; }
    }
}
