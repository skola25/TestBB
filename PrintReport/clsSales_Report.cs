using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReport
{
   public class clsSales_Report
    {
        //public int prod_Id { get; set; }
        public String prod_Id { get; set; }
        public String Prod_name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public String Sls_Per_ID { get; set; }
        public String Total { get { return string.Format("{0}$", Price * Qty); } }
        
    }
}
