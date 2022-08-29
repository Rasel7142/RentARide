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
    
    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            this.drivers = new HashSet<driver>();
            this.normalServices = new HashSet<normalService>();
        }
    
        public int carID { get; set; }
        public Nullable<int> ownerID { get; set; }
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public string carRegNum { get; set; }
        public string carRegYear { get; set; }
        public string carFitnessCertificate { get; set; }
        public string carPicture { get; set; }
        public string serviceType { get; set; }
        public string rate { get; set; }
    
        public virtual carOwner carOwner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<driver> drivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<normalService> normalServices { get; set; }
    }
}