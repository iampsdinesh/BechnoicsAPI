using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BechnoicsAPI.Models;

namespace BechnoicsAPI.Services
{
    /// <summary>
    /// Employee Service In-Memory Class
    /// </summary>
    /// <seealso cref="BechnoicsAPI.Services.IEmployeeService" />
    public class EmployeeMemoryService : IEmployeeService
    {
        /// <summary>
        /// The employees
        /// </summary>
        private readonly List<Employee> employees = new List<Employee>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeMemoryService"/> class.
        /// </summary>
        public EmployeeMemoryService()
        {
            employees.Add(
                new Employee {
                    Id = 1,
                    FirstName = "Srinivasa Dinesh",
                    FamilyName = "Parupalli",
                    StartDateAtBench = new DateTime(2018, 05, 01),
                    EndDateAtBench = new DateTime(2018, 06,30),
                    Skillset = ".NET Tech Arch"});

            employees.Add(
                new Employee
                {
                    Id = 2,
                    FirstName = "Sridhar",
                    FamilyName = "Vemula",
                    StartDateAtBench = new DateTime(2018, 04, 17),
                    EndDateAtBench = new DateTime(2018, 06, 30),
                    Skillset = "Java"
                });

            employees.Add(
                new Employee
                {
                    Id = 3,
                    FirstName = "Chandra Sekhar",
                    FamilyName = "Laghuvarapu",
                    StartDateAtBench = new DateTime(2018, 05, 20),
                    EndDateAtBench = new DateTime(2018, 05, 30),
                    Skillset = "Agile"
                });
        }

        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public bool Add(Employee model)
        {
            model.Id = employees.Max(c => c.Id) + 1;
            employees.Add(model);

            return true;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAll()
        {
            return employees.AsEnumerable();
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(c => c.Id == id);
        }
    }
}
