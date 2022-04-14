using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BrassRooster.Application.TestServers.Dtos;
using BrassRooster.Domain.Enums;
using BrassRooster.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BrassRooster.Application.TestServers
{
    public class TestServerAppService
    {
        private readonly IBrassRoosterDbContext _context;
        private readonly ILogger<TestServerAppService> _logger;

        public TestServerAppService(IBrassRoosterDbContext context, ILogger<TestServerAppService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<TestServerDto>> Get(CancellationToken cancellationToken)
        {
            _logger.LogDebug("Hello world");

            var test = await _context.Employees.ToListAsync(cancellationToken);

            return Enumerable.Range(10, 15).Select(index => new TestServerDto
            {
                Id = index - 10,
                Host = $"10.1.2.{index}",
                Name = $"Test server #{index}",
                UsageState = UsageState.Available,
            });
        }
    }
}
