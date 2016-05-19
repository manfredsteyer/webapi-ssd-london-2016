using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using System.IO;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using FlightApi.Models;

namespace HotelService.Formatter
{
    public class FlatFileFormatter : BufferedMediaTypeFormatter
    {
        public FlatFileFormatter()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/csv"));
        }

        public override bool CanReadType(Type type)
        {
            return typeof(IEnumerable<Flight>).IsAssignableFrom(type);
        }

        public override bool CanWriteType(Type type)
        {
            return typeof(IEnumerable<Flight>).IsAssignableFrom(type);
        }
        public override object ReadFromStream(Type type, Stream readStream, System.Net.Http.HttpContent content, IFormatterLogger formatterLogger)
        {
            var hotels = new List<Flight>();
            StreamReader r = new StreamReader(readStream);

            string line;
            while ((line = r.ReadLine()) != null)
            {
                if (line.Trim() == "") continue;
                var cols = line.Split(',');
                var hotel = new Flight
                {
                    FlightId = Convert.ToInt32(cols[0]),
                    Date = Convert.ToDateTime(cols[1]),
                    From = cols[2],
                    To = cols[3]
                };
                hotels.Add(hotel);
            }

            return hotels;
        }

        public override void WriteToStream(Type type, object value, Stream writeStream, System.Net.Http.HttpContent content)
        {
            var hotels = (IEnumerable<Flight>)value;
            if (hotels == null) return;

            StreamWriter w = new StreamWriter(writeStream);
            foreach (Flight h in hotels)
            {
                w.WriteLine(h.FlightId + "," + h.Date + "," + h.From + "," + h.To);
            }
            w.Flush();

        }

    }

}
