using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Transaction")]
    public class TransactionRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id                  { get; set; }
        public Guid      OrganizationId      { get; set; }
        public Guid      VendorId            { get; set; }
        public string    ReferrenceNumber    { get; set; }
        public DateTime  TransactionDate     { get; set; }
        public string    TransactionType     { get; set; }
        public string    Term                { get; set; }
    }
}
