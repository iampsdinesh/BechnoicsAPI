using BechnoicsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BechnoicsAPI.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(int id);

        bool Add(Employee model);
    }
}
