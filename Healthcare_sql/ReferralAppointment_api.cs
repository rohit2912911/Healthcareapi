//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Healthcare_sql
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReferralAppointment_api
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferralAppointment_api()
        {
            this.RefAppTransactions_api = new HashSet<RefAppTransactions_api>();
        }
    
        public int ReferralAppointmentPK_Id { get; set; }
        public int ProviderReferralPK_Id { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public short Status { get; set; }
        public System.DateTime InsertedOn { get; set; }
    
        public virtual ProviderReferral ProviderReferral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAppTransactions_api> RefAppTransactions_api { get; set; }
        public virtual ReferralStatusMaster ReferralStatusMaster { get; set; }
    }
}
