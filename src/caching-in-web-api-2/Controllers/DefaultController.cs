using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.OutputCache.V2;
namespace caching_in_web_api_2.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/Get/")]
        //Cache time is 60 seconds.
        [CacheOutput(ServerTimeSpan = 60)]
        public Response GetRandomString()
        {
            var response = new Response();
            response.RandomString = Guid.NewGuid().ToString().Replace("-", "");
            response.CacheDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            return response;
        }
    }
}
