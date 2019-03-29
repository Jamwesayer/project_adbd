using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class FinishedOrderHeader
    {
        public FinishedOrderHeader()
        {
            FinishedOrderDetails = new HashSet<FinishedOrderDetails>();
        }

        public int FinishedOrderNumber { get; set; }
        public string RetailerName { get; set; }
        public int RetailerSiteCode { get; set; }
        public int RetailerContactCode { get; set; }
        public int EmpId { get; set; }
        public int BranchCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderMethodCode { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }
        public DateTime ShipDate { get; set; }
        public string FinCodeId { get; set; }

        public ICollection<FinishedOrderDetails> FinishedOrderDetails { get; set; }
    }
}
