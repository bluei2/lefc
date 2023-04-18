using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class FuelModel{
        public Guid      Id               { get; set; }
        public Guid      ShipmentId      { get; set; }
        public float     Estimate        { get; set; }
        public float     Used            { get; set; }
    }
}
