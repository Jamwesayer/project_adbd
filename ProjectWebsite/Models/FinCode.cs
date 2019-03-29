using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class FinCode
    {
        public FinCode()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public string FinCodeId { get; set; }
        public string Typevar { get; set; }
        public string Description { get; set; }

        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
