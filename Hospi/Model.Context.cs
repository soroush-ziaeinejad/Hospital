﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities3 : DbContext
    {
        public HospitalEntities3()
            : base("name=HospitalEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accountant> Accountants { get; set; }
        public DbSet<Ambulance_service> Ambulance_service { get; set; }
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Drugstore_Bill> Drugstore_Bill { get; set; }
        public DbSet<Drugstore_cashier> Drugstore_cashier { get; set; }
        public DbSet<Drugstore> Drugstores { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<security> securities { get; set; }
        public DbSet<servant> servants { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Warrant> Warrants { get; set; }
        public DbSet<Warrant1> Warrants1 { get; set; }
    }
}
