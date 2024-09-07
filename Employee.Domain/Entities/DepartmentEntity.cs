using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Entities
{
    public class DepartmentEntity : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }

    }
}
