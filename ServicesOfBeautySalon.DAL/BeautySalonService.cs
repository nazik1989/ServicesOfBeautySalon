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
    
    public partial class BeautySalonService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeautySalonService()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public long ID { get; set; }
        public long BeautySalonID { get; set; }
        public long ServiceID { get; set; }
        public long MasterUserID { get; set; }
        public Nullable<int> Discount { get; set; }
    
        public virtual BeautySalon BeautySalon { get; set; }
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
