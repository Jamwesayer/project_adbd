using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
            ProductLine = new HashSet<ProductLine>();
        }

        public int ProductTypeCode { get; set; }
        public string ProductTypeEn { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<ProductLine> ProductLine { get; set; }
    }
}
