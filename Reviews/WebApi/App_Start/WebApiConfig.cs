using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();


            builder.EntitySet<Review>("Reviews");

            builder.Function("AverageNote").Returns<double>().Parameter<int>("MovieID");


            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                 model: builder.GetEdmModel());
                
        }
    }
}
