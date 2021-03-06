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
    
    public partial class ReferralAdded_api
    {
        public int ReferralAdd_Id { get; set; }
        public int ProviderReferralPK_Id { get; set; }
        public string ProviderFrom { get; set; }
        public string ProviderTo { get; set; }
        public string Patient { get; set; }
        public byte ProvFromType { get; set; }
        public byte ProvToType { get; set; }
        public byte PatientType { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string QueryId { get; set; }
        public string Source { get; set; }
    
        public virtual ReferralAdded_api ReferralAdded_api1 { get; set; }
        public virtual ReferralAdded_api ReferralAdded_api2 { get; set; }
    }
}
