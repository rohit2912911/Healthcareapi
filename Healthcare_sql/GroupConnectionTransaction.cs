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
    
    public partial class GroupConnectionTransaction
    {
        public int GroupConnTransactionPk_Id { get; set; }
        public int GroupConnectPK_Id { get; set; }
        public string Provider_id { get; set; }
        public int Group_Id { get; set; }
        public System.DateTime insertedon { get; set; }
        public short SeenStatus { get; set; }
        public short Status { get; set; }
        public byte ProvType { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual ReferralStatusMaster ReferralStatusMaster { get; set; }
        public virtual ReferralStatusMaster ReferralStatusMaster1 { get; set; }
        public virtual ReferralStatusMaster ReferralStatusMaster2 { get; set; }
    }
}
