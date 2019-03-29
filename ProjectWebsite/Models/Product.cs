using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Product
    {
        public Product()
        {
            BookingProduct = new HashSet<BookingProduct>();
            InventoryLevels = new HashSet<InventoryLevels>();
            OrderDetails = new HashSet<OrderDetails>();
            SalesTarget = new HashSet<SalesTarget>();
            SupplierProduct = new HashSet<SupplierProduct>();
            WarehouseProducts = new HashSet<WarehouseProducts>();
        }

        public int ProductNumber { get; set; }
        public DateTime IntroductionDate { get; set; }
        public int ProductTypeCode { get; set; }
        public float ProductionCost { get; set; }
        public float Margin { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProdSize { get; set; }
        public string Color { get; set; }
        public float UnitPrice { get; set; }
        public string Category { get; set; }

        public ProductType ProductTypeCodeNavigation { get; set; }
        public ICollection<BookingProduct> BookingProduct { get; set; }
        public ICollection<InventoryLevels> InventoryLevels { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<SalesTarget> SalesTarget { get; set; }
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
        public ICollection<WarehouseProducts> WarehouseProducts { get; set; }
    }
}
