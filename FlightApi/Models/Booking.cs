using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApi.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Flight Flight { get; set; }
    }
}
