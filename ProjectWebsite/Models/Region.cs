using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Region
    {
        public Region()
        {
            Branch = new HashSet<Branch>();
            Country = new HashSet<Country>();
            InventoryLevels = new HashSet<InventoryLevels>();
            RetailerSite = new HashSet<RetailerSite>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public ICollection<Branch> Branch { get; set; }
        public ICollection<Country> Country { get; set; }
        public ICollection<InventoryLevels> InventoryLevels { get; set; }
        public ICollection<RetailerSite> RetailerSite { get; set; }
    }
}
