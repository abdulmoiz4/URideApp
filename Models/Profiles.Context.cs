﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace URideApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalMVCProjectQueryEntities : DbContext
    {
        public FinalMVCProjectQueryEntities()
            : base("name=FinalMVCProjectQueryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminInfo> AdminInfoes { get; set; }
        public virtual DbSet<CarCompany> CarCompanies { get; set; }
        public virtual DbSet<CarInfo> CarInfoes { get; set; }
        public virtual DbSet<DriverInfo> DriverInfoes { get; set; }
        public virtual DbSet<PassengerInfo> PassengerInfoes { get; set; }
    }
}
