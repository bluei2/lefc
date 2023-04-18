using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Freight")]
    public class FreightRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid          Id                  { get; set; }
        public string        ShipmentId          { get; set; }
        public string        CustomerId          { get; set; }
        public string        RouteId             { get; set; }
        public string        DeliveryNumber      { get; set; }
        public DateTime      ArrivalDateTime     { get; set; }
        public DateTime      DepartureDateTime   { get; set; }
        public DateTime      LoadingStartTime    { get; set; }
        public DateTime      LoadingEndTime      { get; set; }
    }
}
