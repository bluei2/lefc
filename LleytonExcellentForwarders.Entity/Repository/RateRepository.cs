using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Rate")]
    public class RateRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id              { get; set; }
        public Guid      RouteId         { get; set; }
        public Guid      TypeId          { get; set; }
        public decimal   Amount          { get; set; }

    }
}
