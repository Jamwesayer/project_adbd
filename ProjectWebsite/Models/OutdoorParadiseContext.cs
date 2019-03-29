using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectWebsite.Models
{
    public partial class OutdoorParadiseContext : DbContext
    {
        public OutdoorParadiseContext()
        {
        }

        public OutdoorParadiseContext(DbContextOptions<OutdoorParadiseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appraisal> Appraisal { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingProduct> BookingProduct { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeGoTraining> EmployeeGoTraining { get; set; }
        public virtual DbSet<Excursion> Excursion { get; set; }
        public virtual DbSet<FinCode> FinCode { get; set; }
        public virtual DbSet<FinishedOrderDetails> FinishedOrderDetails { get; set; }
        public virtual DbSet<FinishedOrderHeader> FinishedOrderHeader { get; set; }
        public virtual DbSet<GoTraining> GoTraining { get; set; }
        public virtual DbSet<GoTrainingJobs> GoTrainingJobs { get; set; }
        public virtual DbSet<InventoryLevels> InventoryLevels { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<OrderMethod> OrderMethod { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductForecast> ProductForecast { get; set; }
        public virtual DbSet<ProductLine> ProductLine { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Retailer> Retailer { get; set; }
        public virtual DbSet<RetailerSite> RetailerSite { get; set; }
        public virtual DbSet<RetailerType> RetailerType { get; set; }
        public virtual DbSet<ReturnedItem> ReturnedItem { get; set; }
        public virtual DbSet<ReturnReason> ReturnReason { get; set; }
        public virtual DbSet<SalesTarget> SalesTarget { get; set; }
        public virtual DbSet<SportTrip> SportTrip { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProduct { get; set; }
        public virtual DbSet<Traveller> Traveller { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseProducts> WarehouseProducts { get; set; }

        // Unable to generate entity type for table 'dbo.Bonus'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=JAMES\\SQLEXPRESS01;Database=OutdoorParadise;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appraisal>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.Date });

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Appraisal__emp_i__5629CD9C");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.BookingId)
                    .HasColumnName("booking_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bookingdate)
                    .HasColumnName("bookingdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Insurance).HasColumnName("insurance");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("payment_method")
                    .HasMaxLength(255);

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Booking__custome__2A164134");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK__Booking__trip_id__2B0A656D");
            });

            modelBuilder.Entity<BookingProduct>(entity =>
            {
                entity.HasKey(e => e.BpId);

                entity.ToTable("Booking_Product");

                entity.Property(e => e.BpId)
                    .HasColumnName("bp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingProduct)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Booking_P__booki__2DE6D218");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BookingProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Booking_P__produ__2EDAF651");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchCode);

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(40);

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.PostalZone)
                    .HasColumnName("postal_zone")
                    .HasMaxLength(10);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Branch__country___440B1D61");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Branch__dept_id__44FF419A");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Branch__region_i__4316F928");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => new { e.PrNumber, e.ProductNumber });

                entity.Property(e => e.PrNumber).HasColumnName("pr_number");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Discount).HasColumnName("discount");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.Country1)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasMaxLength(3);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Country__currenc__3B75D760");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Country__region___3C69FB99");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasColumnName("currency_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(255);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasMaxLength(255);

                entity.Property(e => e.MaxQuantity).HasColumnName("max_quantity");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptHeadId).HasColumnName("dept_head_id");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("dept_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptHead)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.DeptHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departmen__dept___4BAC3F29");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeneDayCare).HasColumnName("bene_day_care");

                entity.Property(e => e.BeneHealthIns).HasColumnName("bene_health_ins");

                entity.Property(e => e.BeneLifeIns).HasColumnName("bene_life_ins");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cv)
                    .HasColumnName("CV")
                    .HasMaxLength(1);

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpFname)
                    .IsRequired()
                    .HasColumnName("emp_fname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLname)
                    .IsRequired()
                    .HasColumnName("emp_lname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(6);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsSalesStaff).HasColumnName("is_sales_staff");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SsNumber)
                    .HasColumnName("ss_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("termination_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasMaxLength(20);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employee__branch__4AB81AF0");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Employee__dept_i__48CFD27E");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Employee__job_id__49C3F6B7");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employee__manage__47DBAE45");
            });

            modelBuilder.Entity<EmployeeGoTraining>(entity =>
            {
                entity.HasKey(e => new { e.GoTrainingId, e.EmpId });

                entity.ToTable("Employee_Go_Training");

                entity.Property(e => e.GoTrainingId).HasColumnName("go_training_id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployeeGoTraining)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Employee___emp_i__534D60F1");

                entity.HasOne(d => d.GoTraining)
                    .WithMany(p => p.EmployeeGoTraining)
                    .HasForeignKey(d => d.GoTrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee___go_tr__52593CB8");
            });

            modelBuilder.Entity<Excursion>(entity =>
            {
                entity.HasKey(e => e.ExId);

                entity.Property(e => e.ExId)
                    .HasColumnName("ex_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExName)
                    .IsRequired()
                    .HasColumnName("ex_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ExPrice).HasColumnName("ex_price");

                entity.Property(e => e.Guide).HasMaxLength(255);

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Excursion)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK__Excursion__trip___2739D489");
            });

            modelBuilder.Entity<FinCode>(entity =>
            {
                entity.ToTable("Fin_code");

                entity.Property(e => e.FinCodeId)
                    .HasColumnName("fin_code_id")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Typevar)
                    .IsRequired()
                    .HasColumnName("typevar")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinishedOrderDetails>(entity =>
            {
                entity.HasKey(e => e.FinishedOrderDetailCode);

                entity.ToTable("finished_order_details");

                entity.Property(e => e.FinishedOrderDetailCode)
                    .HasColumnName("finished_order_detail_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.FinishedOrderNumber).HasColumnName("finished_order_number");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UnitCost).HasColumnName("unit_cost");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UnitSalePrice).HasColumnName("unit_sale_price");

                entity.HasOne(d => d.FinishedOrderNumberNavigation)
                    .WithMany(p => p.FinishedOrderDetails)
                    .HasForeignKey(d => d.FinishedOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__finished___finis__04E4BC85");
            });

            modelBuilder.Entity<FinishedOrderHeader>(entity =>
            {
                entity.HasKey(e => e.FinishedOrderNumber);

                entity.ToTable("Finished_Order_Header");

                entity.HasIndex(e => e.OrderDate)
                    .HasName("Index_Finished_Order_Header");

                entity.Property(e => e.FinishedOrderNumber)
                    .HasColumnName("finished_order_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.FinCodeId)
                    .IsRequired()
                    .HasColumnName("fin_code_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderMethodCode).HasColumnName("order_method_code");

                entity.Property(e => e.RetailerContactCode).HasColumnName("retailer_contact_code");

                entity.Property(e => e.RetailerName)
                    .IsRequired()
                    .HasColumnName("retailer_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RetailerSiteCode).HasColumnName("retailer_site_code");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("ship_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GoTraining>(entity =>
            {
                entity.ToTable("Go_Training");

                entity.Property(e => e.GoTrainingId).HasColumnName("go_training_id");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasColumnName("course")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<GoTrainingJobs>(entity =>
            {
                entity.HasKey(e => new { e.GoTrainingId, e.JobId });

                entity.ToTable("Go_Training_Jobs");

                entity.Property(e => e.GoTrainingId).HasColumnName("go_training_id");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.IsMandatory).HasColumnName("is_Mandatory");

                entity.HasOne(d => d.GoTraining)
                    .WithMany(p => p.GoTrainingJobs)
                    .HasForeignKey(d => d.GoTrainingId)
                    .HasConstraintName("FK__Go_Traini__go_tr__1BC821DD");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.GoTrainingJobs)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Go_Traini__job_i__1CBC4616");
            });

            modelBuilder.Entity<InventoryLevels>(entity =>
            {
                entity.HasKey(e => new { e.InventoryYear, e.InventoryMonth, e.ProductNumber });

                entity.ToTable("Inventory_Levels");

                entity.Property(e => e.InventoryYear).HasColumnName("inventory_year");

                entity.Property(e => e.InventoryMonth).HasColumnName("inventory_month");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.InventoryCount).HasColumnName("inventory_count");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.InventoryLevels)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__count__208CD6FA");

                entity.HasOne(d => d.ProductNumberNavigation)
                    .WithMany(p => p.InventoryLevels)
                    .HasForeignKey(d => d.ProductNumber)
                    .HasConstraintName("FK__Inventory__produ__1F98B2C1");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.InventoryLevels)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__regio__2180FB33");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("job_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("job_title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxSalary).HasColumnName("max_salary");

                entity.Property(e => e.MinSalary).HasColumnName("min_salary");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailCode);

                entity.ToTable("Order_Details");

                entity.Property(e => e.OrderDetailCode).HasColumnName("order_detail_code");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UnitCost).HasColumnName("unit_cost");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UnitSalePrice).HasColumnName("unit_sale_price");

                entity.HasOne(d => d.OrderNumberNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderNumber)
                    .HasConstraintName("FK__Order_Det__order__7F2BE32F");

                entity.HasOne(d => d.ProductNumberNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Det__produ__00200768");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => e.OrderNumber);

                entity.ToTable("Order_Header");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.FinCodeId)
                    .HasColumnName("fin_code_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderMethodCode).HasColumnName("order_method_code");

                entity.Property(e => e.RetailerContactCode).HasColumnName("retailer_contact_code");

                entity.Property(e => e.RetailerSiteCode).HasColumnName("retailer_site_code");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Order_Hea__branc__787EE5A0");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK__Order_Hea__cust___7B5B524B");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Order_Hea__emp_i__778AC167");

                entity.HasOne(d => d.FinCode)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.FinCodeId)
                    .HasConstraintName("FK__Order_Hea__fin_c__7A672E12");

                entity.HasOne(d => d.OrderMethodCodeNavigation)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.OrderMethodCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Hea__order__797309D9");

                entity.HasOne(d => d.RetailerSiteCodeNavigation)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.RetailerSiteCode)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Order_Hea__retai__76969D2E");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__Order_Hea__statu__7C4F7684");
            });

            modelBuilder.Entity<OrderMethod>(entity =>
            {
                entity.HasKey(e => e.OrderMethodCode);

                entity.ToTable("Order_Method");

                entity.Property(e => e.OrderMethodCode).HasColumnName("order_method_code");

                entity.Property(e => e.OrderMethodEn)
                    .IsRequired()
                    .HasColumnName("order_method_en")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductNumber);

                entity.HasIndex(e => e.ProductTypeCode)
                    .HasName("Index_Product");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.IntroductionDate)
                    .HasColumnName("introduction_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Margin).HasColumnName("margin");

                entity.Property(e => e.ProdSize)
                    .HasColumnName("prod_size")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasColumnName("product_image")
                    .HasMaxLength(150);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductTypeCode).HasColumnName("product_type_code");

                entity.Property(e => e.ProductionCost).HasColumnName("production_cost");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.HasOne(d => d.ProductTypeCodeNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__product__5CD6CB2B");
            });

            modelBuilder.Entity<ProductForecast>(entity =>
            {
                entity.HasKey(e => new { e.ProductNumber, e.Year, e.Month });

                entity.ToTable("Product_Forecast");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.ExpectedVolume).HasColumnName("expected_volume");
            });

            modelBuilder.Entity<ProductLine>(entity =>
            {
                entity.HasKey(e => e.ProductLineCode);

                entity.ToTable("Product_Line");

                entity.Property(e => e.ProductLineCode).HasColumnName("product_line_code");

                entity.Property(e => e.ProductLineEn)
                    .IsRequired()
                    .HasColumnName("product_line_en")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductTypeCode).HasColumnName("product_type_code");

                entity.HasOne(d => d.ProductTypeCodeNavigation)
                    .WithMany(p => p.ProductLine)
                    .HasForeignKey(d => d.ProductTypeCode)
                    .HasConstraintName("FK__Product_L__produ__5FB337D6");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeCode);

                entity.ToTable("Product_Type");

                entity.Property(e => e.ProductTypeCode).HasColumnName("product_type_code");

                entity.Property(e => e.ProductTypeEn)
                    .IsRequired()
                    .HasColumnName("product_type_en")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.PrNumber);

                entity.Property(e => e.PrNumber)
                    .HasColumnName("pr_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Retailer>(entity =>
            {
                entity.HasKey(e => e.RetailerCode);

                entity.Property(e => e.RetailerCode).HasColumnName("retailer_code");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RetailerCodeMr).HasColumnName("retailer_codeMR");

                entity.Property(e => e.RetailerTypeCode).HasColumnName("retailer_type_code");

                entity.HasOne(d => d.RetailerCodeMrNavigation)
                    .WithMany(p => p.Retailer)
                    .HasForeignKey(d => d.RetailerCodeMr)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Retailer__retail__66603565");

                entity.HasOne(d => d.RetailerTypeCodeNavigation)
                    .WithMany(p => p.Retailer)
                    .HasForeignKey(d => d.RetailerTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Retailer__retail__6754599E");
            });

            modelBuilder.Entity<RetailerSite>(entity =>
            {
                entity.HasKey(e => e.RetailerSiteCode);

                entity.ToTable("Retailer_Site");

                entity.Property(e => e.RetailerSiteCode).HasColumnName("retailer_site_code");

                entity.Property(e => e.ActiveIndicator).HasColumnName("active_indicator");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(40);

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.PostalZone)
                    .HasColumnName("postal_zone")
                    .HasMaxLength(10);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RetailerCode).HasColumnName("retailer_code");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.RetailerSite)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Retailer___count__6C190EBB");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RetailerSite)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Retailer___regio__6B24EA82");

                entity.HasOne(d => d.RetailerCodeNavigation)
                    .WithMany(p => p.RetailerSite)
                    .HasForeignKey(d => d.RetailerCode)
                    .HasConstraintName("FK__Retailer___retai__6A30C649");
            });

            modelBuilder.Entity<RetailerType>(entity =>
            {
                entity.HasKey(e => e.RetailerTypeCode);

                entity.ToTable("Retailer_Type");

                entity.Property(e => e.RetailerTypeCode).HasColumnName("retailer_type_code");

                entity.Property(e => e.TypeNameEn)
                    .IsRequired()
                    .HasColumnName("type_name_en")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ReturnedItem>(entity =>
            {
                entity.HasKey(e => e.ReturnCode);

                entity.ToTable("Returned_Item");

                entity.HasIndex(e => e.ReturnReasonCode)
                    .HasName("Index_Returned_Item")
                    .HasFilter("([return_reason_code] IS NOT NULL)");

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("return_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderDetailCode).HasColumnName("order_detail_code");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnQuantity).HasColumnName("return_quantity");

                entity.Property(e => e.ReturnReasonCode).HasColumnName("return_reason_code");

                entity.HasOne(d => d.OrderDetailCodeNavigation)
                    .WithMany(p => p.ReturnedItem)
                    .HasForeignKey(d => d.OrderDetailCode)
                    .HasConstraintName("FK__Returned___order__3587F3E0");

                entity.HasOne(d => d.ReturnReasonCodeNavigation)
                    .WithMany(p => p.ReturnedItem)
                    .HasForeignKey(d => d.ReturnReasonCode)
                    .HasConstraintName("FK__Returned___retur__367C1819");
            });

            modelBuilder.Entity<ReturnReason>(entity =>
            {
                entity.HasKey(e => e.ReturnReasonCode);

                entity.ToTable("Return_Reason");

                entity.Property(e => e.ReturnReasonCode).HasColumnName("return_reason_code");

                entity.Property(e => e.ReasonDescriptionEn)
                    .HasColumnName("reason_description_en")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SalesTarget>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.SalesYear, e.SalesPeriod, e.RetailerCode, e.ProductNumber });

                entity.ToTable("Sales_Target");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.SalesYear).HasColumnName("sales_year");

                entity.Property(e => e.SalesPeriod).HasColumnName("sales_period");

                entity.Property(e => e.RetailerCode).HasColumnName("retailer_code");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.IsAccomplished).HasColumnName("is_Accomplished");

                entity.Property(e => e.SalesTarget1).HasColumnName("sales_target");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.SalesTarget)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Sales_Tar__emp_i__07C12930");

                entity.HasOne(d => d.ProductNumberNavigation)
                    .WithMany(p => p.SalesTarget)
                    .HasForeignKey(d => d.ProductNumber)
                    .HasConstraintName("FK__Sales_Tar__produ__09A971A2");

                entity.HasOne(d => d.RetailerCodeNavigation)
                    .WithMany(p => p.SalesTarget)
                    .HasForeignKey(d => d.RetailerCode)
                    .HasConstraintName("FK__Sales_Tar__retai__08B54D69");
            });

            modelBuilder.Entity<SportTrip>(entity =>
            {
                entity.HasKey(e => e.TripId);

                entity.ToTable("Sport_Trip");

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.Property(e => e.AllowChildren).HasColumnName("allow_children");

                entity.Property(e => e.MaxParticipants).HasColumnName("max_participants");

                entity.Property(e => e.MinParticipants).HasColumnName("min_participants");

                entity.Property(e => e.TripDate)
                    .HasColumnName("trip_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TripDuration).HasColumnName("trip_duration");

                entity.Property(e => e.TripName)
                    .IsRequired()
                    .HasColumnName("trip_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TripPrice).HasColumnName("trip_price");

                entity.Property(e => e.TripTransport)
                    .IsRequired()
                    .HasColumnName("trip_transport")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.StatusDesc)
                    .IsRequired()
                    .HasColumnName("status_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("status_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier__countr__0E6E26BF");
            });

            modelBuilder.Entity<SupplierProduct>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.ProductNumber });

                entity.ToTable("Supplier_Product");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchase_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ProductNumberNavigation)
                    .WithMany(p => p.SupplierProduct)
                    .HasForeignKey(d => d.ProductNumber)
                    .HasConstraintName("FK__Supplier___produ__123EB7A3");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierProduct)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Supplier___suppl__114A936A");
            });

            modelBuilder.Entity<Traveller>(entity =>
            {
                entity.HasIndex(e => new { e.TravellerName, e.TravellerId })
                    .HasName("Index_Traveller");

                entity.Property(e => e.TravellerId)
                    .HasColumnName("traveller_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TravellerBirthDate)
                    .HasColumnName("traveller_birth_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TravellerGender)
                    .IsRequired()
                    .HasColumnName("traveller_gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TravellerName)
                    .IsRequired()
                    .HasColumnName("traveller_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Traveller)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK__Traveller__trip___245D67DE");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Warehouse__count__151B244E");
            });

            modelBuilder.Entity<WarehouseProducts>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseId, e.ProductNumber });

                entity.ToTable("Warehouse_Products");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.ProductNumber).HasColumnName("product_number");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.ProductNumberNavigation)
                    .WithMany(p => p.WarehouseProducts)
                    .HasForeignKey(d => d.ProductNumber)
                    .HasConstraintName("FK__Warehouse__produ__18EBB532");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WarehouseProducts)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK__Warehouse__wareh__17F790F9");
            });
        }
    }
}
