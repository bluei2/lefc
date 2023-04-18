using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class SalaryMapper{
        public static SalaryRepository ToRepository(this SalaryModel model){
            return new SalaryRepository{
                Id           = model.Id,
                RouteId      = model.RouteId,
                TypeId       = model.TypeId,
                RoleId       = model.RoleId,
                Amount       = model.Amount
            };
        }
        public static SalaryModel ToModel(this SalaryRepository repository){
            return new SalaryModel{
                Id           = repository.Id,
                RouteId      = repository.RouteId,
                TypeId       = repository.TypeId,
                RoleId       = repository.RoleId,
                Amount       = repository.Amount
            };
        }
    }
}
