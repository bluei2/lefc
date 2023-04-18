using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class TypeMapper{
        public static TypeRepository ToRepository(this TypeModel model){
            return new TypeRepository{
                Id       = model.Id,
                Name     = model.Name
            };
        }
        public static TypeModel ToModel(this TypeRepository repository){
            return new TypeModel{
                Id       = repository.Id,
                Name     = repository.Name
            };
        }
    }
}
