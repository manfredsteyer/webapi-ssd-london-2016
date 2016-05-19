using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var proxy = new FlightApi();

            
            //proxy.HttpClient.DefaultRequestHeaders.

            var all = proxy.Flight.GetAll();
            

            Console.ReadLine();

        }
    }
}
