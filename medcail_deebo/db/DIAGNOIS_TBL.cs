//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace medcail_deebo.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIAGNOIS_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIAGNOIS_TBL()
        {
            this.DIGLIST_TBL = new HashSet<DIGLIST_TBL>();
        }
    
        public decimal DIG_ID { get; set; }
        public Nullable<decimal> DIG_CODE { get; set; }
        public string DIG_NAME { get; set; }
        public string DIG_TYPE { get; set; }
        public string DIG_NOTE { get; set; }
        public Nullable<decimal> CLI_ID { get; set; }
    
        public virtual CLINC_TBL CLINC_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIGLIST_TBL> DIGLIST_TBL { get; set; }
    }
}