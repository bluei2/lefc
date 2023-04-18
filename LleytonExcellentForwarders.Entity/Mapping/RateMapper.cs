using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class RateMapper{
        public static RateRepository ToRepository(this RateModel model){
            return new RateRepository{
                Id           = model.Id,
                RouteId      = model.RouteId,
                TypeId       = model.TypeId,
                Amount       = model.Amount
            };
        }
        public static RateModel ToModel(this RateRepository repository){
            return new RateModel{
                Id           = repository.Id,
                RouteId      = repository.RouteId,
                TypeId       = repository.TypeId,
                Amount       = repository.Amount
            };
        }
    }
}
