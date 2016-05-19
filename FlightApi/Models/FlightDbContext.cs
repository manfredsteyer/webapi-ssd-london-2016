using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApi.Models
{
    public class FlightDbContext: DbContext
    {
        public FlightDbContext(): base("FlightDb")
        {
            this.Configuration.LazyLoadingEnabled = false;
            // Database.SetInitializer(new DropCreateDatabaseAlways<FlightDbContext>());
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Flight> Flights { get; set; }

    }
}
