//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bookings()
        {
            this.BookingDetails = new HashSet<BookingDetails>();
        }
    
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long UserID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public Nullable<long> CouponID { get; set; }
        public Nullable<long> TransactionID { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
        public virtual Coupons Coupons { get; set; }
        public virtual Transactions Transactions { get; set; }
        public virtual Users Users { get; set; }
    }
}
