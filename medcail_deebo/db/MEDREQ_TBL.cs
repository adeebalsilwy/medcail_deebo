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
    
    public partial class MEDREQ_TBL
    {
        public decimal MEDREQ_ID { get; set; }
        public Nullable<decimal> MEDREQ_CODE { get; set; }
        public string MEDREQ_NAME { get; set; }
        public Nullable<System.DateTime> MEDREQ_DATE { get; set; }
        public string MEDREQ_TIME { get; set; }
        public string MEDREQ_RESULT { get; set; }
        public string MEDREQ_NOTE { get; set; }
        public Nullable<decimal> MEDCHECK_ID { get; set; }
        public Nullable<decimal> CUST_ID { get; set; }
        public Nullable<decimal> CLI_ID { get; set; }
        public Nullable<decimal> VIS_ID { get; set; }
        public string MEDREQ_STATE { get; set; }
    
        public virtual CLINC_TBL CLINC_TBL { get; set; }
        public virtual MEDCHEK_TBL MEDCHEK_TBL { get; set; }
    }
}
