//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModelClass.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class POEntity
    {
        public int POID { get; set; }
        public string PONo { get; set; }
        public int MasterID { get; set; }
        public int ProjectID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public string Memo { get; set; }
    }
}
