//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CarInfo
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Model { get; set; }
        public string Company { get; set; }
        public string RegNo { get; set; }
        public Nullable<int> CarDriver { get; set; }
        public Nullable<int> Car_Company { get; set; }
    
        public virtual CarCompany CarCompany { get; set; }
        public virtual DriverInfo DriverInfo { get; set; }
    }
}