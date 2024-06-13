using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }

        public IEnumerable<Class> classes { get; set; } = new List<Class>();
    }
}