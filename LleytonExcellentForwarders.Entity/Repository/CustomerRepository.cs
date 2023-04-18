using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Customer")]
    public class CustomerRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id          { get; set; }
        public string    Code        { get; set; }
        public string    Name        { get; set; }
        public string    Address     { get; set; }
        public bool      IsDeleted   { get; set; }
    }
}
