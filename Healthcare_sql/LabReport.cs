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
    
    public partial class LabReport
    {
        public string user_id { get; set; }
        public System.DateTime test_date { get; set; }
        public string performing_lab { get; set; }
        public string vcTestId { get; set; }
        public string lab_address { get; set; }
        public string city_name { get; set; }
        public string lab_zone { get; set; }
        public string lab_pincode { get; set; }
        public string doctor_name { get; set; }
        public string doctor_address { get; set; }
        public string vcDiseaseId { get; set; }
        public string result { get; set; }
        public string comments { get; set; }
        public string vcOtherDiseaseName { get; set; }
        public string vcOtherCity { get; set; }
        public string vcOtherDoctor { get; set; }
        public string vcOtherTest { get; set; }
        public Nullable<double> vcActualRange { get; set; }
        public Nullable<double> vcMinRange { get; set; }
        public Nullable<double> vcMaxRange { get; set; }
    }
}
