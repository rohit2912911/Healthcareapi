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
    
    public partial class tempqpinfo
    {
        public int Id { get; set; }
        public string vcProviderId { get; set; }
        public string vcQueryId { get; set; }
        public string vcNukeFname { get; set; }
        public string vcNukeLname { get; set; }
        public string vcNukeEmail { get; set; }
        public string vcNukeUnit { get; set; }
        public string vcNukeStreet { get; set; }
        public Nullable<bool> btIsPaid { get; set; }
        public string vcUpdatedBy { get; set; }
        public string vcUserName { get; set; }
        public string vcRoleType { get; set; }
        public Nullable<System.DateTime> dtupdationDate { get; set; }
        public string vcNukeCity { get; set; }
        public string vcNukeState { get; set; }
        public string vcNukeCountry { get; set; }
        public string vcNukePostalcode { get; set; }
        public string vcNukeCategory { get; set; }
        public string vcNukeCell { get; set; }
        public string vcProviderType { get; set; }
        public Nullable<decimal> S_Points { get; set; }
        public Nullable<decimal> R_Points { get; set; }
    }
}
