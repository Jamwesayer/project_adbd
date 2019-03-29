using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Employee = new HashSet<Employee>();
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int BranchCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int RegionId { get; set; }
        public string PostalZone { get; set; }
        public int CountryCode { get; set; }
        public int DeptId { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public Department Dept { get; set; }
        public Region Region { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
