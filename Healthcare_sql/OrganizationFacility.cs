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
    
    public partial class OrganizationFacility
    {
        public string org_id { get; set; }
        public Nullable<bool> hostel_facility { get; set; }
        public Nullable<decimal> beds { get; set; }
        public Nullable<bool> mess_facility { get; set; }
        public Nullable<bool> meal_facility { get; set; }
        public Nullable<bool> daycare_facility { get; set; }
        public Nullable<bool> medical_facility { get; set; }
        public Nullable<bool> tution_facility { get; set; }
        public string tution_rch { get; set; }
        public Nullable<bool> therapy_facility { get; set; }
        public string therapy_rch { get; set; }
        public Nullable<bool> training_facility { get; set; }
        public string training_rch { get; set; }
        public string schemes { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_datetime { get; set; }
        public string medical_rch { get; set; }
    }
}
