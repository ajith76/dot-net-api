using Microsoft.AspNetCore.Mvc;
using CompanyAPI.Models;
using CompanyAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _service;

        [ActivatorUtilitiesConstructor]
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _service.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = _service.GetById(id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        // POST endpoint removed per request.

    }
}