﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITwo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> employeeLsit = new List<Employee>();

            employeeLsit.Add(new Employee { Address = "Delhi", Id = 1, Name = "Swati" });
            employeeLsit.Add(new Employee { Address = "Shimla", Id = 2, Name = "Piya" });
            employeeLsit.Add(new Employee { Address = "Gurgaon", Id = 3, Name = "Harshita" });
            employeeLsit.Add(new Employee { Address = "Mumbai", Id = 4, Name = "Mona" });
            employeeLsit.Add(new Employee { Address = "Calcutta", Id = 5, Name = "Arti" });

            return employeeLsit;
        }
    }
}
