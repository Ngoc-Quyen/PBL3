//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int IdSchedule { get; set; }
        public string IdCar { get; set; }
        public string IdCustomer { get; set; }
        public string IdStaff { get; set; }
        public string Location { get; set; }
        public string Destination { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Staff Staff { get; set; }
    }
}