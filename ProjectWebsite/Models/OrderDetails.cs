using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            ReturnedItem = new HashSet<ReturnedItem>();
        }

        public int OrderDetailCode { get; set; }
        public int OrderNumber { get; set; }
        public int ProductNumber { get; set; }
        public short Quantity { get; set; }
        public float UnitCost { get; set; }
        public float UnitPrice { get; set; }
        public float UnitSalePrice { get; set; }

        public OrderHeader OrderNumberNavigation { get; set; }
        public Product ProductNumberNavigation { get; set; }
        public ICollection<ReturnedItem> ReturnedItem { get; set; }
    }
}
