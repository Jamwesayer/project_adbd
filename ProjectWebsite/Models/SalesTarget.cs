using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class SalesTarget
    {
        public int EmpId { get; set; }
        public int SalesYear { get; set; }
        public int SalesPeriod { get; set; }
        public int SalesTarget1 { get; set; }
        public int RetailerCode { get; set; }
        public int ProductNumber { get; set; }
        public bool? IsAccomplished { get; set; }

        public Employee Emp { get; set; }
        public Product ProductNumberNavigation { get; set; }
        public Retailer RetailerCodeNavigation { get; set; }
    }
}
