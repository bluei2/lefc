using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class RouteMapper{
        public static RouteRepository ToRepository(this RouteModel model){
            return new RouteRepository{
                Id               = model.Id,
                Origin           = model.Origin,
                Destination      = model.Destination,
                Mode             = model.Mode,
                Distance         = model.Distance
            };
        }
        public static RouteModel ToModel(this RouteRepository repository){
            return new RouteModel{
                Id               = repository.Id,
                Origin           = repository.Origin,
                Destination      = repository.Destination,
                Mode             = repository.Mode,
                Distance         = repository.Distance
            };
        }
    }
}
