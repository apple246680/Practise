//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingDetails
    {
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long BookingID { get; set; }
        public long ItemPriceID { get; set; }
        public bool isRefund { get; set; }
        public Nullable<System.DateTime> RefundDate { get; set; }
        public Nullable<long> RefundCancellationPoliciyID { get; set; }
    
        public virtual Bookings Bookings { get; set; }
        public virtual ItemPrices ItemPrices { get; set; }
    }
}
