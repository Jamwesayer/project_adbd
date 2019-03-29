using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Retailer
    {
        public Retailer()
        {
            RetailerSite = new HashSet<RetailerSite>();
            SalesTarget = new HashSet<SalesTarget>();
        }

        public int RetailerCode { get; set; }
        public int? RetailerCodeMr { get; set; }
        public string CompanyName { get; set; }
        public int RetailerTypeCode { get; set; }

        public Employee RetailerCodeMrNavigation { get; set; }
        public RetailerType RetailerTypeCodeNavigation { get; set; }
        public ICollection<RetailerSite> RetailerSite { get; set; }
        public ICollection<SalesTarget> SalesTarget { get; set; }
    }
}
