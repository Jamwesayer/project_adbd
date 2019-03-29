using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class ProductLine
    {
        public int ProductLineCode { get; set; }
        public string ProductLineEn { get; set; }
        public int? ProductTypeCode { get; set; }

        public ProductType ProductTypeCodeNavigation { get; set; }
    }
}
