using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderNumber { get; set; }
        public int? RetailerSiteCode { get; set; }
        public int RetailerContactCode { get; set; }
        public int? EmpId { get; set; }
        public int? BranchCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderMethodCode { get; set; }
        public string FinCodeId { get; set; }
        public int? CustId { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? Status { get; set; }

        public Branch BranchCodeNavigation { get; set; }
        public Customer Cust { get; set; }
        public Employee Emp { get; set; }
        public FinCode FinCode { get; set; }
        public OrderMethod OrderMethodCodeNavigation { get; set; }
        public RetailerSite RetailerSiteCodeNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
