using BrassRooster.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace BrassRooster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestServersController : ControllerBase
    {
        private readonly ILogger<TestServersController> _logger;

        public TestServersController(ILogger<TestServersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TestServer> Get()
        {
            return Enumerable.Range(10, 15).Select(index => new TestServer
            {
                Id = index - 10,
                Host = $"10.1.2.{index}",
                Name = $"Test server #{index}",
                UsageState = Utility.UsageState.Available,
            });
        }
    }
}
