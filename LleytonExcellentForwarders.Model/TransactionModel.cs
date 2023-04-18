using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class TransactionModel{
        public Guid      Id                  { get; set; }
        public Guid      OrganizationId      { get; set; }
        public Guid      VendorId            { get; set; }
        public string    ReferrenceNumber    { get; set; }
        public DateTime  TransactionDate     { get; set; }
        public string    TransactionType     { get; set; }
        public string    Term                { get; set; }
    }
}
