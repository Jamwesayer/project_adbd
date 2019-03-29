using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            Employee = new HashSet<Employee>();
            GoTrainingJobs = new HashSet<GoTrainingJobs>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobTitle { get; set; }
        public float MinSalary { get; set; }
        public float? MaxSalary { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<GoTrainingJobs> GoTrainingJobs { get; set; }
    }
}
