using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class FreightMapper{
        public static FreightRepository ToRepository(this FreightModel model){
            return new FreightRepository{
                Id                    = model.Id,
                ShipmentId            = model.ShipmentId,
                CustomerId            = model.CustomerId,
                RouteId               = model.RouteId,
                DeliveryNumber        = model.DeliveryNumber,
                ArrivalDateTime       = model.ArrivalDateTime,
                DepartureDateTime     = model.DepartureDateTime,
                LoadingStartTime      = model.LoadingStartTime,
                LoadingEndTime        = model.LoadingEndTime
            };
        }
        public static FreightModel ToModel(this FreightRepository repository){
            return new FreightModel{
                Id                   = repository.Id,
                ShipmentId           = repository.ShipmentId,
                CustomerId           = repository.CustomerId,
                RouteId              = repository.RouteId,
                DeliveryNumber       = repository.DeliveryNumber,
                ArrivalDateTime      = repository.ArrivalDateTime,
                DepartureDateTime    = repository.DepartureDateTime,
                LoadingStartTime     = repository.LoadingStartTime,
                LoadingEndTime       = repository.LoadingEndTime
            };
        }
    }
}
