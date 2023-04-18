using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class ShipmentModel{
        public Guid      Id                      { get; set; }
        public Guid      TransactionId           { get; set; }
        public Guid      VehicleId               { get; set; }
        public DateTime  ServiceDate             { get; set; }
        public string    Mode                    { get; set; }
        public string    ShipmentNumber          { get; set; }
        public decimal   Rate                    { get; set; }
        public DateTime  ArrivalDateTime         { get; set; }
        public DateTime  DepartureDateTime       { get; set; }
        public DateTime  LoadingStartTime        { get; set; }
        public DateTime  LoadingEndTime          { get; set; }
        public DateTime  DispatchedDateTime      { get; set; }
        public DateTime  DocumentReturnDateTime  { get; set; }
        public DateTime  ShipmentEndTime         { get; set; }
    }
}
