using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Utility : ControllerBase
    {

        private readonly IConfiguration _config;
        public Utility(IConfiguration config)
        {
            config = _config;
        }

    }
}
