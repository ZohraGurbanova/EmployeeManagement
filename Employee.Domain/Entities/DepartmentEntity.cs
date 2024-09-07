using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Entities
{
    public class DepartmentEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }

    }
}
