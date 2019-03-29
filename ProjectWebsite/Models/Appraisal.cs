using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Appraisal
    {
        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }

        public Employee Emp { get; set; }
    }
}
