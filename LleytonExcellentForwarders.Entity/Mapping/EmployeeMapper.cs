using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class EmployeeMapper{
        public static EmployeeRepository ToRepository(this EmployeeModel model){
            return new EmployeeRepository{
                Id               = model.Id,
                Name             = model.Name,
                RoleId           = model.RoleId,
                Birthdate        = model.Birthdate,
                Address          = model.Address,
                MobileNumber     = model.MobileNumber,
                SssId            = model.SssId,
                SssRate          = model.SssRate,
                PhilhealthId     = model.PhilhealthId,
                PhilhealthRate   = model.PhilhealthRate,
                PagibigId        = model.PagibigId,
                PagibigRate      = model.PagibigRate,
                Rate             = model.Rate,
            };
        }
        public static EmployeeModel ToModel(this EmployeeRepository repository){
            return new EmployeeModel{
                Id               = repository.Id,
                Name             = repository.Name,
                RoleId           = repository.RoleId,
                Birthdate        = repository.Birthdate,
                Address          = repository.Address,
                MobileNumber     = repository.MobileNumber,
                SssId            = repository.SssId,
                SssRate          = repository.SssRate,
                PhilhealthId     = repository.PhilhealthId,
                PhilhealthRate   = repository.PhilhealthRate,
                PagibigId        = repository.PagibigId,
                PagibigRate      = repository.PagibigRate,
                Rate             = repository.Rate
            };
        }
    }
}
