using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace Demo.Components
{
    public class VersionConstraint : IHttpRouteConstraint
    {
        public string Version { get; set; }

        public VersionConstraint(string version)
        {
            this.Version = version;
        }

        public bool Match(
                    System.Net.Http.HttpRequestMessage request,
                    IHttpRoute route,
                    string parameterName,
                    IDictionary<string, object> values,
                    HttpRouteDirection routeDirection)
        {
            string version = "1";

            if (request.Headers.Contains("api-version")) {
                version = request
                            .Headers
                            .GetValues("api-version")
                            .FirstOrDefault();
            }
            if (version == this.Version) return true;
            return false;
        }
    }
}
