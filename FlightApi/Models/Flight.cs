using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApi.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        [MaxLength(30)]
        [Required]
        public string From { get; set; }

        [Required]
        [MaxLength(30)]
        public string To { get; set; }

        public DateTime Date { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
