//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLServerECommerce.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }
    
        public int id { get; set; }
        public string Description { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<System.DateTime> Order_Data { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> Shipped_Date { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Due_Date { get; set; }
        public Nullable<int> Order_target { get; set; }
    
        public virtual ICollection<Order_Details> Order_Details { get; set; }
    }
}
