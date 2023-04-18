using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Fuel")]
    public class FuelRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id              { get; set; }
        public Guid      ShipmentId      { get; set; }
        public float     Estimate        { get; set; }
        public float     Used            { get; set; }
    }
}
