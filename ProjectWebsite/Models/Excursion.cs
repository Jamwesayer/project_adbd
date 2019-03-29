using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Excursion
    {
        public int ExId { get; set; }
        public float ExPrice { get; set; }
        public string ExName { get; set; }
        public int TripId { get; set; }
        public string Guide { get; set; }

        public SportTrip Trip { get; set; }
    }
}
