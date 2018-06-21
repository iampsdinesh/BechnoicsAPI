using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BechnoicsAPI.Models;

namespace BechnoicsAPI.Services
{
    public class EmployeeMemoryService : IEmployeeService
    {
        private readonly List<Employee> employees = new List<Employee>();

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

        public bool Add(Employee model)
        {
            model.Id = employees.Max(c => c.Id) + 1;
            employees.Add(model);

            return true;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees.AsEnumerable();
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(c => c.Id == id);
        }
    }
}
