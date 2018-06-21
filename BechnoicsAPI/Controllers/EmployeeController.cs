using BechnoicsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using BechnoicsAPI.ViewModels;
using BechnoicsAPI.Models;

namespace BechnoicsAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet()]
        public IActionResult GetAllEmployees()
        {
            var employeesFromRepo = this.service.GetAll();
           
            var employees = employeesFromRepo.Adapt<EmployeeViewModel[]>();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employeeFromRepo = this.service.GetById(id);

            if(employeeFromRepo == null)
            {
                return NotFound(new { Error = String.Format("Employee with Id : {0} has not been found", id) });

            }

            var employee = employeeFromRepo.Adapt<EmployeeViewModel>();
            
            return Ok(employee);
        }


    }
}
