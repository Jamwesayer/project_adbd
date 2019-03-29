using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Country
    {
        public Country()
        {
            Branch = new HashSet<Branch>();
            InventoryLevels = new HashSet<InventoryLevels>();
            RetailerSite = new HashSet<RetailerSite>();
            Supplier = new HashSet<Supplier>();
            Warehouse = new HashSet<Warehouse>();
        }

        public int CountryCode { get; set; }
        public string Country1 { get; set; }
        public string Language { get; set; }
        public int CurrencyId { get; set; }
        public int RegionId { get; set; }

        public Currency Currency { get; set; }
        public Region Region { get; set; }
        public ICollection<Branch> Branch { get; set; }
        public ICollection<InventoryLevels> InventoryLevels { get; set; }
        public ICollection<RetailerSite> RetailerSite { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
        public ICollection<Warehouse> Warehouse { get; set; }
    }
}
