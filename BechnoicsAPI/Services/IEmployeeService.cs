using BechnoicsAPI.Models;
using System.Collections.Generic;

namespace BechnoicsAPI.Services
{
    /// <summary>
    /// Employee Service - API's
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetAll();

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Employee GetById(int id);

        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        bool Add(Employee model);
    }
}