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
    
    public partial class userallergy
    {
        public string user_id { get; set; }
        public string allergy_id { get; set; }
        public System.DateTime dtStartDate { get; set; }
        public Nullable<System.DateTime> dtEndDate { get; set; }
        public string vcDrugID { get; set; }
        public string vcTreatedBy { get; set; }
        public string vcStatus { get; set; }
        public string vcSaverity { get; set; }
        public string vcRemarks { get; set; }
        public string txHistory { get; set; }
    }
}