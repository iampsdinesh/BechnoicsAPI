using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BechnoicsAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartDateAtBench { get; set; }
        public DateTime EndDateAtBench { get; set; }
        public string Skillset { get; set; }
    }
}
