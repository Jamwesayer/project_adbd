using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class EmployeeGoTraining
    {
        public int GoTrainingId { get; set; }
        public int EmpId { get; set; }

        public Employee Emp { get; set; }
        public GoTraining GoTraining { get; set; }
    }
}
