using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace angularNetcoreAadb2c.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class SecureController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<string> GetData()
        {
            return new string[] { "Hello", "World", "From", "AAD B2C", "Protected", "API" };
        }
    }
}
