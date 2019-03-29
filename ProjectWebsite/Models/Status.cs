using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Status
    {
        public Status()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDesc { get; set; }
        public int Score { get; set; }

        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
