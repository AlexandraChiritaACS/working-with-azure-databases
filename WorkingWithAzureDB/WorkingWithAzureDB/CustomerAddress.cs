//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkingWithAzureDB
{
    using System;
    using System.Collections.Generic;
    // Class to define the address of a Customer linked to address
    public partial class CustomerAddress
    {
        // Main parameters of a customer in DB
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        // Address of a customer
        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
