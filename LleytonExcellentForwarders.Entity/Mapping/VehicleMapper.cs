using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class VehicleMapper{
        public static VehicleRepository ToRepository(this VehicleModel model){
            return new VehicleRepository{
                Id           = model.Id,
                Name         = model.Name,
                PlateNumber  = model.PlateNumber,
                TypeId       = model.TypeId,
                IsPremium    = model.IsPremium
            };
        }
        public static VehicleModel ToModel(this VehicleRepository repository){
            return new VehicleModel{
                Id               = repository.Id,
                Name             = repository.Name,
                PlateNumber      = repository.PlateNumber,
                TypeId           = repository.TypeId,
                IsPremium        = repository.IsPremium
            };
        }
    }
}
