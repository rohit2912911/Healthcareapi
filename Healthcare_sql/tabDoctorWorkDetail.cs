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
    
    public partial class tabDoctorWorkDetail
    {
        public string doc_id { get; set; }
        public Nullable<bool> have_selfClinic { get; set; }
        public string clinic_address { get; set; }
        public string clinic_city { get; set; }
        public string clinic_phone { get; set; }
        public Nullable<decimal> no_of_beds { get; set; }
        public Nullable<bool> have_xray { get; set; }
        public Nullable<bool> have_ultrasound { get; set; }
        public Nullable<bool> credit_card_accepted { get; set; }
        public Nullable<bool> emergency_available { get; set; }
        public Nullable<bool> home_visit { get; set; }
        public string other_facility { get; set; }
        public string health_insurance_tiesup { get; set; }
        public string any_other_details { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_datetime { get; set; }
        public string clinic_area { get; set; }
        public string clinic_Othercity { get; set; }
    }
}
