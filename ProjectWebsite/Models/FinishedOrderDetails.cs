using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class FinishedOrderDetails
    {
        public int FinishedOrderDetailCode { get; set; }
        public int FinishedOrderNumber { get; set; }
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; }
        public float UnitCost { get; set; }
        public float UnitPrice { get; set; }
        public float UnitSalePrice { get; set; }

        public FinishedOrderHeader FinishedOrderNumberNavigation { get; set; }
    }
}
