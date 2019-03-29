using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Department
    {
        public Department()
        {
            Branch = new HashSet<Branch>();
            Employee = new HashSet<Employee>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int DeptHeadId { get; set; }

        public Employee DeptHead { get; set; }
        public ICollection<Branch> Branch { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
