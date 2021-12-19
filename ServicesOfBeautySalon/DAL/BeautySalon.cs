//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesOfBeautySalon.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BeautySalon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeautySalon()
        {
            this.Advertisements = new HashSet<Advertisement>();
            this.BeautySalonServices = new HashSet<BeautySalonService>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public System.TimeSpan OpenTime { get; set; }
        public System.TimeSpan CloseTime { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> CountOfSerivces { get; set; }
        public Nullable<int> CountOfMasters { get; set; }
        public long AdminUserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeautySalonService> BeautySalonServices { get; set; }
    }
}