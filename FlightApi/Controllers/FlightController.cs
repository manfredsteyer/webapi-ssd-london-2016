using Demo.Components;
using FlightApi.Components;
using FlightApi.Data;
using FlightApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;

namespace FlightApi.Controllers
{
    [RoutePrefix("api/flight")]
    public class FlightController : ApiController
    {
        FlightRepository repo = new FlightRepository();

        [CustomEnableQuery()]
        public IQueryable<Flight> GetAll(ODataQueryOptions options)
        {
            return repo.GetQueryable();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                repo.Dispose();
            }
        }

        //[Route("{id}")]
        [VersionedRoute("{id}", "1")]
        public Flight GetById(int id) {
            var repo = new FlightRepository();
            return repo.FindById(id);
        }

        [VersionedRoute("{id}", "2")]
        public Flight GetByIdV2(int id)
        {
            var repo = new FlightRepository();
            return repo.FindById(id);
        }


        [Route("{from}-{to}")]
        public List<Flight> GetByRoute(string from, string to) {
            var repo = new FlightRepository();
            return repo.FindByRoute(from, to);
        }


        public IHttpActionResult Post(Flight flight) {
            var repo = new FlightRepository();
            repo.Save(flight);
            return CreatedAtRoute("DefaultApi", new { id = flight.FlightId }, flight);
        }

      
    }
}
