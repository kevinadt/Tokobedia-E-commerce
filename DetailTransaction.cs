//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TokopediaMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailTransaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual HeaderTransaction HeaderTransaction { get; set; }
    }
}
