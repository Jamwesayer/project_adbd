using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class InventoryLevels
    {
        public short InventoryYear { get; set; }
        public short InventoryMonth { get; set; }
        public int ProductNumber { get; set; }
        public int? InventoryCount { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }

        public Country Country { get; set; }
        public Product ProductNumberNavigation { get; set; }
        public Region Region { get; set; }
    }
}
