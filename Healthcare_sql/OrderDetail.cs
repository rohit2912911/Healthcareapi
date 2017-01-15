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
    
    public partial class OrderDetail
    {
        public string OrderID { get; set; }
        public string EmailID { get; set; }
        public string Phone { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<bool> Dilivered { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}