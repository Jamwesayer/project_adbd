using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int CustId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public float? Discount { get; set; }
        public int? MaxQuantity { get; set; }
        public string Iban { get; set; }

        public ICollection<Booking> Booking { get; set; }
        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
