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
    
    public partial class Query_Pointsdetail
    {
        public int Id { get; set; }
        public string vcSenderId { get; set; }
        public string vcServiceType { get; set; }
        public string vcServiceName { get; set; }
        public string vcQueryId { get; set; }
        public Nullable<System.DateTime> dtupdated_date { get; set; }
        public string vcPointId { get; set; }
    
        public virtual QueryPoint QueryPoint { get; set; }
    }
}