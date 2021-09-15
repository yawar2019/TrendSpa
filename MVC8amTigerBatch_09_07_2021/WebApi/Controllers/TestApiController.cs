using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TestApiController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> SampleData()
        {
            return Ok("Hello World");
        }
    }
}
