using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class RetailerType
    {
        public RetailerType()
        {
            Retailer = new HashSet<Retailer>();
        }

        public int RetailerTypeCode { get; set; }
        public string TypeNameEn { get; set; }

        public ICollection<Retailer> Retailer { get; set; }
    }
}
