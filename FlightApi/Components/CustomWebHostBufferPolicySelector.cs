using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.WebHost;
using System.Web.Routing;

namespace StreamingDemo.Components
{
    public class CustomWebHostBufferPolicySelector : WebHostBufferPolicySelector
    {
        public override bool UseBufferedInputStream(object hostContext)
        {

            HttpContextBase contextBase = hostContext as HttpContextBase;

            if (contextBase != null)
            {
                RouteData routeData = contextBase.Request.RequestContext.RouteData;

                //if (routeData.Values["controller"].ToString().ToLower() == "media")
                {
                    return false;
                }
            }

            return true;
        }

        public override bool UseBufferedOutputStream(HttpResponseMessage response)
        {
            return base.UseBufferedOutputStream(response);
        }
    }

}
