using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class FuelMapper{
        public static FuelRepository ToRepository(this FuelModel model){
            return new FuelRepository{
                Id           = model.Id,
                ShipmentId   = model.ShipmentId,
                Estimate     = model.Estimate,
                Used         = model.Used
            };
        }
        public static FuelModel ToModel(this FuelRepository repository){
            return new FuelModel{
                Id           = repository.Id,
                ShipmentId   = repository.ShipmentId,
                Estimate     = repository.Estimate,
                Used         = repository.Used
            };
        }
    }
}
