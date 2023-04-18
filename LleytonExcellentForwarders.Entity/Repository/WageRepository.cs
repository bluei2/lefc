using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Wage")]
    public class WageRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id              { get; set; }
        public Guid      PayrollId       { get; set; }
        public Guid      EmployeeId      { get; set; }
        public decimal   Rate            { get; set; }
        public decimal   Allowance       { get; set; }
        public decimal   Reimbursement   { get; set; }
        public string    Description     { get; set; }
        public decimal   Total           { get; set; }
        public decimal   Sss             { get; set; }
        public decimal   Philhealth      { get; set; }
        public decimal   Pagibig         { get; set; }
        public decimal   Loan            { get; set; }
        public decimal   Advance         { get; set; }
        public decimal   Product         { get; set; }
        public string    Item            { get; set; }
        public decimal   Damage          { get; set; }
        public decimal   Other           { get; set; }
        public string    Detail          { get; set; }
        public decimal   Deduction       { get; set; }
        public decimal   NetPay          { get; set; }
    }
}
