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
    
    public partial class usp_GetDoctorResearchInterest_Result
    {
        public string doc_id { get; set; }
        public Nullable<bool> btClinicalResearch { get; set; }
        public Nullable<bool> btPreClinicalResearch { get; set; }
        public Nullable<bool> btOtherResearch { get; set; }
        public string vcOtherResearch { get; set; }
        public Nullable<bool> btUniversityFacility { get; set; }
        public Nullable<bool> btGeneralFacility { get; set; }
        public Nullable<bool> btPrimaryFacility { get; set; }
        public Nullable<bool> btOtherFacility { get; set; }
        public string vcOtherFacility { get; set; }
        public Nullable<bool> btPediatricPatient { get; set; }
        public Nullable<bool> btAdultPatient { get; set; }
        public Nullable<bool> btElderlyPatient { get; set; }
        public string vcClinicalStudies { get; set; }
        public string vcUpdatedBy { get; set; }
        public Nullable<System.DateTime> dtUpdationDate { get; set; }
        public string vcExperienceDetails { get; set; }
    }
}