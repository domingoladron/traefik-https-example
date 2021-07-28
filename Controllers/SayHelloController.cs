using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TraefikExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {

        private readonly ILogger<SayHelloController> _logger;

        public SayHelloController(ILogger<SayHelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Howdy from HTTPS via Traefik";
        }
    }
}
