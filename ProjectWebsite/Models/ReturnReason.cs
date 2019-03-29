using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class ReturnReason
    {
        public ReturnReason()
        {
            ReturnedItem = new HashSet<ReturnedItem>();
        }

        public byte ReturnReasonCode { get; set; }
        public string ReasonDescriptionEn { get; set; }

        public ICollection<ReturnedItem> ReturnedItem { get; set; }
    }
}
