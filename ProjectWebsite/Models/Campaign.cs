using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Campaign
    {
        public short PrNumber { get; set; }
        public int ProductNumber { get; set; }
        public float? Discount { get; set; }
    }
}
