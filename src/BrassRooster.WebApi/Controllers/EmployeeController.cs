﻿using System.Collections.Generic;
using BrassRooster.Application.Employees;
using BrassRooster.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrassRooster.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeAppService _appService;

        public EmployeeController(EmployeeAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _appService.Get();
        }
    }
}
