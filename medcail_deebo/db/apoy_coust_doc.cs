using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medcail_deebo.db
{
    internal class apoy_coust_doc
    {
        public Nullable<decimal> APO_CODE { get; set; }
        public decimal APO_ID { get; set; }

        //public decimal CLI_ID { get; set; }

        // public decimal CUST_ID { get; set; }

        public string COUST_NAME { get; set; }
        public string DOC_NAME { get; set; }
       public Nullable<System.DateTime> APO_DATE { get; set; }
       public string APO_TIME { get; set; }


    }
}
