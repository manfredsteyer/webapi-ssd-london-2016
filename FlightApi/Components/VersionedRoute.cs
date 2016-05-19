using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace Demo.Components
{
    public class VersionedRoute : RouteFactoryAttribute
    {
        private string version;

        public VersionedRoute(string template, string version)
            : base(template)
        {
            this.version = version;
        }

        public override IDictionary<string, object> Constraints
        {
            get
            {
                var result = new Dictionary<string, object>();
                result.Add("version", new VersionConstraint(version));
                return result;
            }
        }

    }
}
