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

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<User>("Users");

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                 model: builder.GetEdmModel());
                            
        }
    }
}
