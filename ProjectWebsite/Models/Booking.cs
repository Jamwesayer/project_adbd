using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingProduct = new HashSet<BookingProduct>();
        }

        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int TripId { get; set; }
        public DateTime Bookingdate { get; set; }
        public bool Insurance { get; set; }
        public string PaymentMethod { get; set; }

        public Customer Customer { get; set; }
        public SportTrip Trip { get; set; }
        public ICollection<BookingProduct> BookingProduct { get; set; }
    }
}
