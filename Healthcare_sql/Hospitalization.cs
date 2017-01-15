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
    
    public partial class Hospitalization
    {
        public string user_id { get; set; }
        public System.DateTime admission_date { get; set; }
        public string hos_id { get; set; }
        public Nullable<System.DateTime> discharge_date { get; set; }
        public string hospital_address { get; set; }
        public string hospital_city { get; set; }
        public string hospital_pincode { get; set; }
        public string doctor_address { get; set; }
        public string doctor_contactno { get; set; }
        public string problem_condition_suspected { get; set; }
        public string vcDiseaseID { get; set; }
        public string surgery { get; set; }
        public string surgeonName { get; set; }
        public string treatment_details { get; set; }
        public Nullable<double> cost_of_treatment { get; set; }
        public string discharge_summary { get; set; }
        public Nullable<decimal> hospital_rating { get; set; }
        public string vcOtherDiseaseName { get; set; }
        public string vcOtherHospital { get; set; }
        public string vcOtherDoctor { get; set; }
        public string doctor_name { get; set; }
        public string vcOtherCity { get; set; }
    }
}
