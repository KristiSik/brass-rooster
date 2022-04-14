using System;
using System.Collections.Generic;
using System.Linq;
using BrassRooster.Domain.Enums;
using BrassRooster.Domain.Models;
using Microsoft.Extensions.Logging;

namespace BrassRooster.Application.Employees
{
    public class EmployeeAppService
    {
        private readonly ILogger<EmployeeAppService> _logger;

        public EmployeeAppService(ILogger<EmployeeAppService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Employee> Get()
        {
            _logger.LogDebug("Hello world");

            var rnd = new Random();

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
