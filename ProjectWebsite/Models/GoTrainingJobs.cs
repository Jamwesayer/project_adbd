using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class GoTrainingJobs
    {
        public int GoTrainingId { get; set; }
        public int JobId { get; set; }
        public bool IsMandatory { get; set; }

        public GoTraining GoTraining { get; set; }
        public Jobs Job { get; set; }
    }
}
