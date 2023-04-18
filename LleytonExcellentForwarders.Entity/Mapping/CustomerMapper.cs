using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class CustomerMapper{
        public static CustomerRepository ToRepository(this CustomerModel model){
            return new CustomerRepository{
                Id       = model.Id,
                Code     = model.Code,
                Name     = model.Name,
                Address  = model.Address,
            };
        }
        public static CustomerModel ToModel(this CustomerRepository repository){
            return new CustomerModel{
                Id       = repository.Id,
                Code     = repository.Code,
                Name     = repository.Name,
                Address  = repository.Address,
            };
        }
    }
}