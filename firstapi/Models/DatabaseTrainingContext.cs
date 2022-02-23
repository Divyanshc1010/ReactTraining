using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace firstapi.Models
{
    public partial class DatabaseTrainingContext : DbContext
    {
        public DatabaseTrainingContext()
        {
        }

        public DatabaseTrainingContext(DbContextOptions<DatabaseTrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AEmployee> AEmployees { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AjayEmployee1> AjayEmployee1s { get; set; }
        public virtual DbSet<AjaySbaccount> AjaySbaccounts { get; set; }
        public virtual DbSet<AjaySbtransaction1> AjaySbtransaction1s { get; set; }
        public virtual DbSet<AviBookingDetail> AviBookingDetails { get; set; }
        public virtual DbSet<AviSbaccount> AviSbaccounts { get; set; }
        public virtual DbSet<AviSbtransaction> AviSbtransactions { get; set; }
        public virtual DbSet<BhramarSbaccount> BhramarSbaccounts { get; set; }
        public virtual DbSet<BhramarSbtransaction> BhramarSbtransactions { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<BookingDetailsAbhishek> BookingDetailsAbhisheks { get; set; }
        public virtual DbSet<BookingDetailsAjay> BookingDetailsAjays { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<DarshanSbaccount> DarshanSbaccounts { get; set; }
        public virtual DbSet<DarshanSbtransaction> DarshanSbtransactions { get; set; }
        public virtual DbSet<DemoImageDb> DemoImageDbs { get; set; }
        public virtual DbSet<DivyanshSbaccount> DivyanshSbaccounts { get; set; }
        public virtual DbSet<DivyanshSbtransaction> DivyanshSbtransactions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FlightDetail> FlightDetails { get; set; }
        public virtual DbSet<Harish1> Harish1s { get; set; }
        public virtual DbSet<HarishSbaccount> HarishSbaccounts { get; set; }
        public virtual DbSet<HarishSbtransaction> HarishSbtransactions { get; set; }
        public virtual DbSet<HarshSbaccount> HarshSbaccounts { get; set; }
        public virtual DbSet<HarshSbtransaction> HarshSbtransactions { get; set; }
        public virtual DbSet<JivikaSbaccount> JivikaSbaccounts { get; set; }
        public virtual DbSet<JivikaSbtransaction> JivikaSbtransactions { get; set; }
        public virtual DbSet<LekhanaSbacc> LekhanaSbaccs { get; set; }
        public virtual DbSet<LekhanaSbtran> LekhanaSbtrans { get; set; }
        public virtual DbSet<Manisha> Manishas { get; set; }
        public virtual DbSet<ManishaEmployee> ManishaEmployees { get; set; }
        public virtual DbSet<ManishaSbaccount> ManishaSbaccounts { get; set; }
        public virtual DbSet<ManishaSbtransaction> ManishaSbtransactions { get; set; }
        public virtual DbSet<PracticeTable> PracticeTables { get; set; }
        public virtual DbSet<RaviSbaccount> RaviSbaccounts { get; set; }
        public virtual DbSet<RaviSbtransaction> RaviSbtransactions { get; set; }
        public virtual DbSet<RitikEmployee> RitikEmployees { get; set; }
        public virtual DbSet<RitikSbacoount> RitikSbacoounts { get; set; }
        public virtual DbSet<RitikSbtransaction> RitikSbtransactions { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<SarwatSbaccount> SarwatSbaccounts { get; set; }
        public virtual DbSet<SarwatSbtransaction> SarwatSbtransactions { get; set; }
        public virtual DbSet<SbAccountYash> SbAccountYashes { get; set; }
        public virtual DbSet<SbLoan> SbLoans { get; set; }
        public virtual DbSet<SbTransactionYash> SbTransactionYashes { get; set; }
        public virtual DbSet<SbaccountAbhishek> SbaccountAbhisheks { get; set; }
        public virtual DbSet<SbaccountAmresh> SbaccountAmreshes { get; set; }
        public virtual DbSet<SbaccountSankalp> SbaccountSankalps { get; set; }
        public virtual DbSet<SbaccountShaifali> SbaccountShaifalis { get; set; }
        public virtual DbSet<SbtransactionAbhishek> SbtransactionAbhisheks { get; set; }
        public virtual DbSet<SbtransactionAmresh> SbtransactionAmreshes { get; set; }
        public virtual DbSet<SbtransactionSankalp> SbtransactionSankalps { get; set; }
        public virtual DbSet<SbtransactionShaifali> SbtransactionShaifalis { get; set; }
        public virtual DbSet<ShanSbaccount> ShanSbaccounts { get; set; }
        public virtual DbSet<ShanSbtransaction> ShanSbtransactions { get; set; }
        public virtual DbSet<Shivam> Shivams { get; set; }
        public virtual DbSet<Shivamsbaccount> Shivamsbaccounts { get; set; }
        public virtual DbSet<Shivamsbtransaction> Shivamsbtransactions { get; set; }
        public virtual DbSet<SundaramSbaccount> SundaramSbaccounts { get; set; }
        public virtual DbSet<SundaramSbtransaction> SundaramSbtransactions { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TrasferFund> TrasferFunds { get; set; }
        public virtual DbSet<Trial> Trials { get; set; }
        public virtual DbSet<ZbookingDetail> ZbookingDetails { get; set; }
        public virtual DbSet<ZflightDetail> ZflightDetails { get; set; }
        public virtual DbSet<ZrouteDetail> ZrouteDetails { get; set; }
        public virtual DbSet<ZuserDetail> ZuserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.22.10.31;Database=DatabaseTraining;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AEmployee>(entity =>
            {
                entity.ToTable("a_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AjayEmployee1>(entity =>
            {
                entity.ToTable("Ajay_Employee1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<AjaySbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ajay_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance).HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.MaxBalance).HasColumnName("maxBalance");
            });

            modelBuilder.Entity<AjaySbtransaction1>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ajay_SBTransaction1");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionId");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<AviBookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("Avi_BookingDetails");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.Doj).HasColumnType("datetime");
            });

            modelBuilder.Entity<AviSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Avi_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AviSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Avi_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhramarSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Bhramar_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CurrentAddress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhramarSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Bhramar_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => e.Bookingid);

                entity.Property(e => e.Bookingid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingid");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.Numberofpassengers).HasColumnName("numberofpassengers");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Totalvalue).HasColumnName("totalvalue");
            });

            modelBuilder.Entity<BookingDetailsAbhishek>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("BookingId");

                entity.ToTable("BookingDetails_Abhishek");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.Doj).HasColumnType("smalldatetime");

                entity.Property(e => e.Totalvalue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BookingDetailsAjay>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("BookingDetails_Ajay");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.NumberOfPassengers).HasColumnName("numberOfPassengers");

                entity.Property(e => e.RouteId).HasColumnName("routeId");

                entity.Property(e => e.TotalValue).HasColumnName("totalValue");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.Customerid);

                entity.Property(e => e.Customerid)
                    .ValueGeneratedNever()
                    .HasColumnName("customerid");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customername");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<DarshanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("darshanSBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customerName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DarshanSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("darshanSBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .HasColumnName("transactionId")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DemoImageDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemoImageDb");

                entity.Property(e => e.ImageSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DivyanshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Divyansh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Currentbalance).HasColumnName("currentbalance");

                entity.Property(e => e.Customeraddress)
                    .HasMaxLength(50)
                    .HasColumnName("customeraddress");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customername");
            });

            modelBuilder.Entity<DivyanshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid);

                entity.ToTable("Divyansh_SBTransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Accountnumber).HasColumnName("accountnumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("date")
                    .HasColumnName("transactiondate");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasKey(e => e.Flightid);

                entity.Property(e => e.Flightid)
                    .ValueGeneratedNever()
                    .HasColumnName("flightid");

                entity.Property(e => e.Arrivaltime)
                    .HasColumnType("datetime")
                    .HasColumnName("arrivaltime");

                entity.Property(e => e.Costperseat).HasColumnName("costperseat");

                entity.Property(e => e.Departuretime)
                    .HasColumnType("datetime")
                    .HasColumnName("departuretime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destination");

                entity.Property(e => e.Flightname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flightname");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.Totalcapacity).HasColumnName("totalcapacity");
            });

            modelBuilder.Entity<Harish1>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("id_pk");

                entity.ToTable("harish_1");

                entity.Property(e => e.EmployeeNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("employee_number");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(10)
                    .HasColumnName("employee_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarishSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("harish_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarishSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.ToTable("harish_SBTransaction");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("t_type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Harsh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<HarshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Harsh_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).HasMaxLength(20);
            });

            modelBuilder.Entity<JivikaSbaccount>(entity =>
            {
                entity.ToTable("Jivika_SBAccount");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("customer_address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customer_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<JivikaSbtransaction>(entity =>
            {
                entity.ToTable("Jivika_SBTransaction");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Dot)
                    .HasColumnType("datetime")
                    .HasColumnName("dot");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LekhanaSbacc>(entity =>
            {
                entity.HasKey(e => e.AccNumber)
                    .HasName("PK__Lekhana___A24910AB202506CF");

                entity.ToTable("Lekhana_SBAcc");

                entity.Property(e => e.AccNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("acc_number");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LekhanaSbtran>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK_Lekhana_sbtran");

                entity.ToTable("Lekhana_SBTran");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t_type");
            });

            modelBuilder.Entity<Manisha>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Manisha");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<ManishaEmployee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Manisha_Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doj).HasColumnType("datetime");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ManishaSbaccount>(entity =>
            {
                entity.HasKey(e => e.Accno);

                entity.ToTable("Manisha_SBAccount");

                entity.Property(e => e.Accno).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishaSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("Manisha_SBTransaction");

                entity.Property(e => e.TransId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransID");

                entity.Property(e => e.Amt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PracticeTable>(entity =>
            {
                entity.ToTable("PracticeTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(10)
                    .HasColumnName("product_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RaviSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNo);

                entity.ToTable("Ravi_SBAccount");

                entity.Property(e => e.AccountNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Account No");

                entity.Property(e => e.CurrentBalance).HasColumnName("Current balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("Customer Address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<RaviSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ravi_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Transaction Id");

                entity.Property(e => e.AccountNo).HasColumnName("Account No");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RitikEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ritik_Employee");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.Ename).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<RitikSbacoount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ritik_SBAcoount");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.CurrentBalance).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<RitikSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ritik_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<RouteDetail>(entity =>
            {
                entity.HasKey(e => e.Routeid);

                entity.Property(e => e.Routeid)
                    .ValueGeneratedNever()
                    .HasColumnName("routeid");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.Routedesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("routedesc");
            });

            modelBuilder.Entity<SarwatSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Sarwat_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SarwatSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Sarwat_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbAccountYash>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SB_Account_Yash");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Current Balance");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Address");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<SbLoan>(entity =>
            {
                entity.ToTable("sbLoan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DurationInDays).HasColumnName("durationInDays");

                entity.Property(e => e.Intrest).HasColumnName("intrest");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<SbTransactionYash>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SB_Transaction_Yash");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Transaction ID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<SbaccountAbhishek>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("AccNo");

                entity.ToTable("SBAccount_Abhishek");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountAmresh>(entity =>
            {
                entity.HasKey(e => e.AccNo);

                entity.ToTable("SBAccount_Amresh");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountSankalp>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SBAccount_sankalp");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CreditScore).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbaccountShaifali>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SBAccount_Shaifali");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SbtransactionAbhishek>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("TransactionId");

                entity.ToTable("SBTransaction_Abhishek");

                entity.Property(e => e.TransactionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionAmresh>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Amresh");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionSankalp>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_sankalp");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionShaifali>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Shaifali");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("shan_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customerName");
            });

            modelBuilder.Entity<ShanSbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shan_SBTransaction");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionId).HasColumnName("transactionID");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<Shivam>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_shivam_1");

                entity.ToTable("shivam");

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbaccount>(entity =>
            {
                entity.HasKey(e => e.Accountnumber);

                entity.ToTable("shivamsbaccount");

                entity.Property(e => e.Accountnumber).ValueGeneratedNever();

                entity.Property(e => e.Customeraddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid)
                    .HasName("PK_shivamsbtransaction_1");

                entity.ToTable("shivamsbtransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype")
                    .IsFixedLength(true);

                entity.Property(e => e.Transationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("transationdate");
            });

            modelBuilder.Entity<SundaramSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("sundaram_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SundaramSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("sundaram_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TrasferFund>(entity =>
            {
                entity.ToTable("trasferFunds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.FromAccount).HasColumnName("fromAccount");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<Trial>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Trial");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZbookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("ZBookingDetails");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("Booking Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer Id");

                entity.Property(e => e.DateOfJourney)
                    .HasColumnType("date")
                    .HasColumnName("Date Of Journey");

                entity.Property(e => e.FlightId).HasColumnName("Flight Id");

                entity.Property(e => e.NumberOfPassengers).HasColumnName("Number Of Passengers");

                entity.Property(e => e.RouteId).HasColumnName("Route Id");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Total Cost");
            });

            modelBuilder.Entity<ZflightDetail>(entity =>
            {
                entity.HasKey(e => e.FlightId);

                entity.ToTable("ZFlightDetails");

                entity.Property(e => e.FlightId)
                    .ValueGeneratedNever()
                    .HasColumnName("Flight Id");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Arrival Time");

                entity.Property(e => e.CostPerSeat).HasColumnName("Cost Per Seat");

                entity.Property(e => e.DepartureTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Departure Time");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Flight Name");

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCapacity).HasColumnName("Total Capacity");
            });

            modelBuilder.Entity<ZrouteDetail>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("ZRouteDetails");

                entity.Property(e => e.RouteId)
                    .ValueGeneratedNever()
                    .HasColumnName("Route Id");

                entity.Property(e => e.FlightId).HasColumnName("Flight Id");

                entity.Property(e => e.RouteDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Route Description");
            });

            modelBuilder.Entity<ZuserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("ZUserDetails");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("User Id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User Type");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
