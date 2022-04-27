//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marys_Auto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Vehicles = new HashSet<Vehicle>();
        }
    
        public int Customer_ID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerStreetAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerPhoneAreaCode { get; set; }
        public string CustomerPhoneNumber { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}