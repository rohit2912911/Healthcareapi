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
    
    public partial class BankInfoTerm
    {
        public string ban_id { get; set; }
        public string donor_age { get; set; }
        public string donor_others { get; set; }
        public Nullable<bool> recipient_registeration_yes { get; set; }
        public Nullable<bool> recipient_registeration_no { get; set; }
        public string registeration_text { get; set; }
        public string recipient_others { get; set; }
        public string any_other { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_datetime { get; set; }
    }
}