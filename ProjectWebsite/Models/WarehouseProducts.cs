using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class WarehouseProducts
    {
        public int WarehouseId { get; set; }
        public int ProductNumber { get; set; }
        public int Quantity { get; set; }

        public Product ProductNumberNavigation { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
