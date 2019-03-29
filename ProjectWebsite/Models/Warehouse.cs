using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            WarehouseProducts = new HashSet<WarehouseProducts>();
        }

        public int WarehouseId { get; set; }
        public int CountryCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public ICollection<WarehouseProducts> WarehouseProducts { get; set; }
    }
}
