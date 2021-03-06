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
    
    public partial class ClinicalDoctor
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string std_code { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string specialization_name { get; set; }
        public string hospital_name { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_datetime { get; set; }
        public int Cdoc_id { get; set; }
    
        public virtual ClinicalResearchDetail ClinicalResearchDetail { get; set; }
    }
}
