using System.Web.Http;

namespace WebApi2_Simple
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute(
                name: "AllLocation",
                routeTemplate: "location",
                defaults: new {controller = "Location", action = "Get"}
                );
        }
    }
}