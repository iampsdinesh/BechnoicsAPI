using BechnoicsAPI.Models;
using BechnoicsAPI.Services;
using BechnoicsAPI.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BechnoicsAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        /// <summary>
        /// The service
        /// </summary>
        private readonly IEmployeeService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IActionResult GetAllEmployees()
        {
            var employeesFromRepo = this.service.GetAll();

            var employees = employeesFromRepo.Adapt<EmployeeViewModel[]>();

            return Ok(employees);
        }

        /// <summary>
        /// Gets the employee details.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetEmployeeDetails")]
        public IActionResult GetEmployeeDetails(int id)
        {
            var employeeFromRepo = this.service.GetById(id);

            if (employeeFromRepo == null)
            {
                return NotFound(new { Error = String.Format("Employee with Id : {0} has not been found", id) });
            }

            var employee = employeeFromRepo.Adapt<EmployeeViewModel>();

            return Ok(employee);
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeCreate">The employee create.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost()]
        public IActionResult AddEmployee([FromBody] EmployeeCreateViewModel employeeCreate)
        {
            if (employeeCreate == null)
            {
                return BadRequest();
            }

            var employeeEntity = employeeCreate.Adapt<Employee>();

            if (!this.service.Add(employeeEntity))
            {
                throw new Exception($"Creation of employee failed!!!");
            }

            var employeeToReturn = employeeEntity.Adapt<EmployeeViewModel>();

            return CreatedAtRoute("GetEmployeeDetails", new { id = employeeToReturn.Id }, employeeToReturn);
        }
    }
}