using HotelService.Formatter;
using HotelService.Handler;
using Newtonsoft.Json.Serialization;
using StreamingDemo.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace FlightApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste

            // Web-API-Routen
            config.MapHttpAttributeRoutes();

            
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Formatters.Add(new BsonMediaTypeFormatter());
            config.Formatters.Add(new FlatFileFormatter());


            config.Services.Replace(
                typeof(IHostBufferPolicySelector),
                new CustomWebHostBufferPolicySelector());


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
