using FlightApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApi.Data
{
    public class FlightRepository
    {

        static FlightRepository() {
            using (var ctx = new FlightDbContext())
            {
                ctx.Database.Delete();
                ctx.Database.CreateIfNotExists();

                var flight1 = new Flight {
                    From = "Vienna",
                    To = "London",
                    Date = DateTime.Now,
                    Bookings = new List<Booking> {
                        new Booking {
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new Booking {
                            FirstName = "Emmett",
                            LastName = "Brown"
                        }
                    }
                };

                var flight2 = new Flight
                {
                    From = "Berlin",
                    To = "London",
                    Date = DateTime.Now
                };

                ctx.Flights.Add(flight1);
                ctx.Flights.Add(flight2);
                ctx.SaveChanges();
            }
        }


        public Flight FindById(int id) {
            using (var ctx = new FlightDbContext()) {
                return ctx.Flights.Include(f => f.Bookings).FirstOrDefault(f => f.FlightId == id);
            }
        }

        public List<Flight> FindByRoute(string from, string to) {
            using (var ctx = new FlightDbContext())
            {
                return ctx.Flights.Where(f => f.From == from && f.To == to).ToList();
            }

        }

        FlightDbContext ctx = new FlightDbContext();

        public IQueryable<Flight> GetQueryable() {
            return ctx.Flights.Where(f => f.To == "London");
        }

        public void Dispose() {
            ctx.Dispose();
        }

        public List<Flight> FindAll() {
            using (var ctx = new FlightDbContext())
            {
                return ctx.Flights.ToList();
            }

        }

        public void Save(Flight flight) {
            using (var ctx = new FlightDbContext())
            {
                ctx.Flights.Attach(flight);
                ctx.Entry(flight).State = EntityState.Modified;
                ctx.SaveChanges();
            }

        }



    }
}
