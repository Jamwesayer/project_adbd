using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Country = new HashSet<Country>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
