using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Appraisal = new HashSet<Appraisal>();
            Department = new HashSet<Department>();
            EmployeeGoTraining = new HashSet<EmployeeGoTraining>();
            InverseManager = new HashSet<Employee>();
            OrderHeader = new HashSet<OrderHeader>();
            Retailer = new HashSet<Retailer>();
            SalesTarget = new HashSet<SalesTarget>();
        }

        public int EmpId { get; set; }
        public int? ManagerId { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public int? DeptId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int? JobId { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string SsNumber { get; set; }
        public float? Salary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? BeneHealthIns { get; set; }
        public bool? BeneLifeIns { get; set; }
        public bool? BeneDayCare { get; set; }
        public string Gender { get; set; }
        public bool? IsSalesStaff { get; set; }
        public string WorkPhone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public byte[] Cv { get; set; }
        public int? BranchCode { get; set; }

        public Branch BranchCodeNavigation { get; set; }
        public Department Dept { get; set; }
        public Jobs Job { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Appraisal> Appraisal { get; set; }
        public ICollection<Department> Department { get; set; }
        public ICollection<EmployeeGoTraining> EmployeeGoTraining { get; set; }
        public ICollection<Employee> InverseManager { get; set; }
        public ICollection<OrderHeader> OrderHeader { get; set; }
        public ICollection<Retailer> Retailer { get; set; }
        public ICollection<SalesTarget> SalesTarget { get; set; }
    }
}
