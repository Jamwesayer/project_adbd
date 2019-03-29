using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class GoTraining
    {
        public GoTraining()
        {
            EmployeeGoTraining = new HashSet<EmployeeGoTraining>();
            GoTrainingJobs = new HashSet<GoTrainingJobs>();
        }

        public int GoTrainingId { get; set; }
        public int Year { get; set; }
        public string Course { get; set; }

        public ICollection<EmployeeGoTraining> EmployeeGoTraining { get; set; }
        public ICollection<GoTrainingJobs> GoTrainingJobs { get; set; }
    }
}
