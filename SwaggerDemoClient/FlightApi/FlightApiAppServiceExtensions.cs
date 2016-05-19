using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace SwaggerDemoClient
{
    public static class FlightApiAppServiceExtensions
    {
        public static FlightApi CreateFlightApi(this IAppServiceClient client)
        {
            return new FlightApi(client.CreateHandler());
        }

        public static FlightApi CreateFlightApi(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new FlightApi(client.CreateHandler(handlers));
        }

        public static FlightApi CreateFlightApi(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new FlightApi(uri, client.CreateHandler(handlers));
        }

        public static FlightApi CreateFlightApi(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new FlightApi(rootHandler, client.CreateHandler(handlers));
        }
    }
}
