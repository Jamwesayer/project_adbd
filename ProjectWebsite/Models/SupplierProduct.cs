using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class SupplierProduct
    {
        public int SupplierId { get; set; }
        public int ProductNumber { get; set; }
        public float Price { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Product ProductNumberNavigation { get; set; }
        public Supplier Supplier { get; set; }
    }
}
