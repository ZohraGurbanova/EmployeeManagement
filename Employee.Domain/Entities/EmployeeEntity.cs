using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }

     
        [ForeignKey(nameof(DepartmentId))]
        public virtual DepartmentEntity Department { get; set; }

    }
}
