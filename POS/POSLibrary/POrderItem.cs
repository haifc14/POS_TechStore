//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class POrderItem
    {
        public int OrderItemsID { get; set; }
        public Nullable<int> Barcode { get; set; }
        public Nullable<int> OrderNumber { get; set; }
    
        public virtual POrder POrder { get; set; }
        public virtual PProduct PProduct { get; set; }
    }
}