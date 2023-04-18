using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class PayrollModel {
        public Guid          Id          { get; set; }
        public DateTime      PayDate     { get; set; }
        public DateTime      DateFrom    { get; set; }
        public DateTime      DateTo      { get; set; }
        public decimal       Total       { get; set; }
    }
}
