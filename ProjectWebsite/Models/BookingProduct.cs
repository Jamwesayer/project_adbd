using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class BookingProduct
    {
        public int BpId { get; set; }
        public int BookingId { get; set; }
        public int ProductId { get; set; }

        public Booking Booking { get; set; }
        public Product Product { get; set; }
    }
}
