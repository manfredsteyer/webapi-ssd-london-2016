using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.OData;
using System.Web.OData.Query;

namespace FlightApi.Components
{
    public class CustomEnableQuery: EnableQueryAttribute
    {
        public override void ValidateQuery(HttpRequestMessage request, ODataQueryOptions queryOptions)
        {
            var expandToBookings = false;

            if (queryOptions.SelectExpand != null) {
                expandToBookings = queryOptions
                                    .SelectExpand
                                    .RawExpand.Contains("Bookings");
            }

            if (expandToBookings) throw new SecurityException("not allowed");

            base.ValidateQuery(request, queryOptions);
        }
    }
}
