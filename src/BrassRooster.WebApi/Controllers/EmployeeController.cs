using System.Collections.Generic;
using BrassRooster.Application.Employees;
using BrassRooster.Application.Employees.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrassRooster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeAppService _appService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(EmployeeAppService appService, ILogger<EmployeeController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            return _appService.Get();
        }
    }
}
