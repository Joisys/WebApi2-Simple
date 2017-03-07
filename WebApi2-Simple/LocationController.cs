using System.Collections.Generic;
using System.Web.Http;
using WebApi2_Simple.Model;

namespace WebApi2_Simple
{
    public class LocationController : ApiController
    {
        public IHttpActionResult Get()
        {
            IList<Location> locations = new List<Location>();
            locations.Add(new Location {Name = "London"});
            locations.Add(new Location { Name = "Cardiff" });
            locations.Add(new Location { Name = "Cochin" });
            return Ok(locations);
        }

    }
}