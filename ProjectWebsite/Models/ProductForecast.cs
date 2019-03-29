using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class ProductForecast
    {
        public int ProductNumber { get; set; }
        public short Year { get; set; }
        public short Month { get; set; }
        public int? ExpectedVolume { get; set; }
    }
}
