using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class RetailerSite
    {
        public RetailerSite()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int RetailerSiteCode { get; set; }
        public int RetailerCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int RegionId { get; set; }
        public string PostalZone { get; set; }
        public int CountryCode { get; set; }
        public bool ActiveIndicator { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public Region Region { get; set; }
        public Retailer RetailerCodeNavigation { get; set; }
        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
