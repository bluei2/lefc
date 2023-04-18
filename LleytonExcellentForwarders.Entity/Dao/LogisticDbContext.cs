using LleytonExcellentForwarders.Entity.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace LleytonExcellentForwarders.Entity.Dao
{
    public class LogisticDbContext : DbContext{
        public LogisticDbContext(DbContextOptions<LogisticDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        public virtual DbSet<CustomerRepository>         Customers           { get; set; }
        public virtual DbSet<EmployeeRepository>         Employees           { get; set; }
        public virtual DbSet<FreightRepository>          Freights            { get; set; }
        public virtual DbSet<FuelRepository>             Fuels               { get; set; }
        public virtual DbSet<OrganizationRepository>     Organizations       { get; set; }
        public virtual DbSet<PayrollRepository>          Payrolls            { get; set; }
        public virtual DbSet<RateRepository>             Rates               { get; set; }
        public virtual DbSet<RoleRepository>             Roles               { get; set; }
        public virtual DbSet<RouteRepository>            Routes              { get; set; }
        public virtual DbSet<SalaryRepository>           Salaries            { get; set; }
        public virtual DbSet<ShipmentRepository>         Shipments           { get; set; }
        public virtual DbSet<TransactionRepository>      Transactions        { get; set; }
        public virtual DbSet<TypeRepository>             Types               { get; set; }
        public virtual DbSet<VehicleRepository>          Vehicles            { get; set; }
        public virtual DbSet<VendorRepository>           Vendors             { get; set; }
        public virtual DbSet<WageRepository>             Wages               { get; set; }
    }
}