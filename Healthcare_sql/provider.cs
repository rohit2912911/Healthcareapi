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
    
    public partial class provider
    {
        public string ProviderId { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string category_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string ProvideTypeId { get; set; }
        public string ProviderType { get; set; }
        public string ProviderImage { get; set; }
        public string ProviderQualification { get; set; }
        public string Approval { get; set; }
        public string country { get; set; }
        public string gender { get; set; }
        public Nullable<int> Visibility { get; set; }
    }
}
