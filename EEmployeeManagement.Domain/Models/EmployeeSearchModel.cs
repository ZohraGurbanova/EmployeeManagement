using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Models
{
    public class EmployeeSearchModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? DepartmentId { get; set; }
        public int Page { get; set;}
        public int PageSize { get; set; }

    }
}
