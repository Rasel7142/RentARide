//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Renat_A_Ride.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class driver
    {
        public int driverID { get; set; }
        public Nullable<int> carID { get; set; }
        public string driverName { get; set; }
        public string driverLicenseNum { get; set; }
        public string driverAddress { get; set; }
    
        public virtual car car { get; set; }
    }
}