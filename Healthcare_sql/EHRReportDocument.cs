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
    
    public partial class EHRReportDocument
    {
        public int EHRReportDocumentPK_ID { get; set; }
        public Nullable<byte> EntityID { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentURL { get; set; }
        public string EntityRecordID { get; set; }
        public System.DateTime InsertedOn { get; set; }
    
        public virtual ReferralEntityMaster ReferralEntityMaster { get; set; }
    }
}
