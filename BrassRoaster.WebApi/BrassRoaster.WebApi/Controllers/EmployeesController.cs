using BrassRoaster.WebApi.Models;
using BrassRoaster.WebApi.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrassRoaster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            Random rnd = new Random();
            return Enumerable.Range(1, 5).Select(index => new Employee
            {
                Id = index,
                FirstName = $"{(char)(index + 48)}",
                LastName = $"{(char)(index + 48)}",
                Email = $"user{(char)(index + 48)}{(char)(index + 50)}@gmail.com",
                Role = (Role)(index % (Enum.GetValues<Role>().Length - 1) + 1),
                AvailabilityStatus = (AvailabilityStatus)rnd.Next(1, Enum.GetValues<AvailabilityStatus>().Length - 1),
            })
            .ToArray();
        }
    }
}
