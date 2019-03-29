using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            SupplierProduct = new HashSet<SupplierProduct>();
        }

        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int CountryCode { get; set; }
        public string City { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
    }
}
