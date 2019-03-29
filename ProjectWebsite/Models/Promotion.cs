using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Promotion
    {
        public short PrNumber { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Description { get; set; }
    }
}
