using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrassRooster.Domain.Enums;
using BrassRooster.Domain.Models;
using BrassRooster.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BrassRooster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestServerController : ControllerBase
    {
        private readonly IBrassRoosterDbContext _context;
        private readonly ILogger<TestServerController> _logger;

        public TestServerController(IBrassRoosterDbContext context, ILogger<TestServerController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<TestServer>> Get()
        {
            var test = await _context.Employees.ToListAsync();

            return Enumerable.Range(10, 15).Select(index => new TestServer
            {
                Id = index - 10,
                Host = $"10.1.2.{index}",
                Name = $"Test server #{index}",
                UsageState = UsageState.Available,
            });
        }
    }
}
