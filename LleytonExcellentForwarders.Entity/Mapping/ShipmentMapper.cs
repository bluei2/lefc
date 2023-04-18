using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class ShipmentMapper{
        public static ShipmentRepository ToRepository(this ShipmentModel model){
            return new ShipmentRepository{
                Id                       = model.Id,
                TransactionId            = model.TransactionId,
                VehicleId                = model.VehicleId,
                ServiceDate              = model.ServiceDate,
                Mode                     = model.Mode,
                ShipmentNumber           = model.ShipmentNumber,
                Rate                     = model.Rate,
                ArrivalDateTime          = model.ArrivalDateTime,
                DepartureDateTime        = model.DepartureDateTime,
                LoadingStartTime         = model.LoadingStartTime,
                LoadingEndTime           = model.LoadingEndTime,
                DispatchedDateTime       = model.DispatchedDateTime,
                DocumentReturnDateTime   = model.DocumentReturnDateTime,
                ShipmentEndTime          = model.ShipmentEndTime
            };
        }
        public static ShipmentModel ToModel(this ShipmentRepository repository){
            return new ShipmentModel{
                Id                       = repository.Id,
                TransactionId            = repository.TransactionId,
                VehicleId                = repository.VehicleId,
                ServiceDate              = repository.ServiceDate,
                Mode                     = repository.Mode,
                ShipmentNumber           = repository.ShipmentNumber,
                Rate                     = repository.Rate,
                ArrivalDateTime          = repository.ArrivalDateTime,
                DepartureDateTime        = repository.DepartureDateTime,
                LoadingStartTime         = repository.LoadingStartTime,
                LoadingEndTime           = repository.LoadingEndTime,
                DispatchedDateTime       = repository.DispatchedDateTime,
                DocumentReturnDateTime   = repository.DocumentReturnDateTime,
                ShipmentEndTime          = repository.ShipmentEndTime
            };
        }
    }
}
