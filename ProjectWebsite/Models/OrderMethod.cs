using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class OrderMethod
    {
        public OrderMethod()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int OrderMethodCode { get; set; }
        public string OrderMethodEn { get; set; }

        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
