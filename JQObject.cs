using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingApp.Models
{
    public class JQObject
    {
        //JQObject entity
        public int SrNo { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public double Amount { get; set; }
        
    }
}
