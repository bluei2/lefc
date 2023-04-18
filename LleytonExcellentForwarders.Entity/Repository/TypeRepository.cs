using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Type")]
    public class TypeRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id          { get; set; }
        public string    Name        { get; set; }
    }
}
