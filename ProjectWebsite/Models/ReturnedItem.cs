using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class ReturnedItem
    {
        public int ReturnCode { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int OrderDetailCode { get; set; }
        public byte? ReturnReasonCode { get; set; }
        public short? ReturnQuantity { get; set; }

        public OrderDetails OrderDetailCodeNavigation { get; set; }
        public ReturnReason ReturnReasonCodeNavigation { get; set; }
    }
}
