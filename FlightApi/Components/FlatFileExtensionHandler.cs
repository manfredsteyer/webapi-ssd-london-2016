using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;

namespace HotelService.Handler
{
   
    public class FlatFileExtensionHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var requestString = request.RequestUri.ToString();

            var lastSegment = request.RequestUri.Segments.Last();
           

            if (lastSegment.EndsWith(".txt"))
            {

                var newUri = requestString.Replace(".txt", "");
                request.RequestUri = new Uri(newUri, UriKind.Absolute);
                request.Headers.Accept.Clear();
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/csv"));
            }
            return base.SendAsync(request, cancellationToken);
        }

    }

}