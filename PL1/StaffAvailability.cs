//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL1
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffAvailability
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int PeriodId { get; set; }
        public bool Mon08 { get; set; }
        public bool Mon09 { get; set; }
        public bool Mon10 { get; set; }
        public bool Mon11 { get; set; }
        public bool Mon12 { get; set; }
        public bool Mon13 { get; set; }
        public bool Mon14 { get; set; }
        public bool Mon15 { get; set; }
        public bool Mon16 { get; set; }
        public bool Mon17 { get; set; }
        public bool Mon18 { get; set; }
        public bool Mon19 { get; set; }
        public bool Mon20 { get; set; }
        public bool Tue08 { get; set; }
        public bool Tue09 { get; set; }
        public bool Tue10 { get; set; }
        public bool Tue11 { get; set; }
        public bool Tue12 { get; set; }
        public bool Tue13 { get; set; }
        public bool Tue14 { get; set; }
        public bool Tue15 { get; set; }
        public bool Tue16 { get; set; }
        public bool Tue17 { get; set; }
        public bool Tue18 { get; set; }
        public bool Tue19 { get; set; }
        public bool Tue20 { get; set; }
        public bool Wed08 { get; set; }
        public bool Wed09 { get; set; }
        public bool Wed10 { get; set; }
        public bool Wed11 { get; set; }
        public bool Wed12 { get; set; }
        public bool Wed13 { get; set; }
        public bool Wed14 { get; set; }
        public bool Wed15 { get; set; }
        public bool Wed16 { get; set; }
        public bool Wed17 { get; set; }
        public bool Wed18 { get; set; }
        public bool Wed19 { get; set; }
        public bool Wed20 { get; set; }
        public bool Thu08 { get; set; }
        public bool Thu09 { get; set; }
        public bool Thu10 { get; set; }
        public bool Thu11 { get; set; }
        public bool Thu12 { get; set; }
        public bool Thu13 { get; set; }
        public bool Thu14 { get; set; }
        public bool Thu15 { get; set; }
        public bool Thu16 { get; set; }
        public bool Thu17 { get; set; }
        public bool Thu18 { get; set; }
        public bool Thu19 { get; set; }
        public bool Thu20 { get; set; }
        public bool Fri08 { get; set; }
        public bool Fri09 { get; set; }
        public bool Fri10 { get; set; }
        public bool Fri11 { get; set; }
        public bool Fri12 { get; set; }
        public bool Fri13 { get; set; }
        public bool Fri14 { get; set; }
        public bool Fri15 { get; set; }
        public bool Fri16 { get; set; }
        public bool Fri17 { get; set; }
        public bool Fri18 { get; set; }
        public bool Fri19 { get; set; }
        public bool Fri20 { get; set; }
        public bool Sat08 { get; set; }
        public bool Sat09 { get; set; }
        public bool Sat10 { get; set; }
        public bool Sat11 { get; set; }
        public bool Sat12 { get; set; }
        public bool Sat13 { get; set; }
        public bool Sat14 { get; set; }
        public bool Sat15 { get; set; }
        public bool Sat16 { get; set; }
        public bool Sat17 { get; set; }
        public bool Sat18 { get; set; }
        public bool Sat19 { get; set; }
        public bool Sat20 { get; set; }
        public bool Sun08 { get; set; }
        public bool Sun09 { get; set; }
        public bool Sun10 { get; set; }
        public bool Sun11 { get; set; }
        public bool Sun12 { get; set; }
        public bool Sun13 { get; set; }
        public bool Sun14 { get; set; }
        public bool Sun15 { get; set; }
        public bool Sun16 { get; set; }
        public bool Sun17 { get; set; }
        public bool Sun18 { get; set; }
        public bool Sun19 { get; set; }
        public bool Sun20 { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual AvailabilityPeriod AvailabilityPeriod { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
