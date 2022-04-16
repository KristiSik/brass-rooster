using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BrassRooster.Application.TestServers;
using BrassRooster.Application.TestServers.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BrassRooster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestServerController : ControllerBase
    {
        private readonly TestServerAppService _testServerAppService;

        public TestServerController(TestServerAppService testServerAppService)
        {
            _testServerAppService = testServerAppService;
        }

        [HttpGet]
        public Task<IEnumerable<TestServerDto>> Get(CancellationToken cancellationToken)
        {
            return _testServerAppService.Get(cancellationToken);
        }
    }
}
