using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Payroll")]
    public class PayrollRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id              { get; set; }
        public DateTime  PayDate         { get; set; }
        public DateTime  DateFrom        { get; set; }
        public DateTime  DateTo          { get; set; }
        public decimal   Total           { get; set; }
    }
}
