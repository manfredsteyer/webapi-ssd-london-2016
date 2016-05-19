using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightApi api = new FlightApi();
            var all = api.Flight.GetAll();
            Console.WriteLine("done");
        }
    }
}
