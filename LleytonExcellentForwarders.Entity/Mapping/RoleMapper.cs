using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class RoleMapper{
        public static RoleRepository ToRepository(this RoleModel model){
            return new RoleRepository{
                Id       = model.Id,
                Name     = model.Name
            };
        }
        public static RoleModel ToModel(this RoleRepository repository){
            return new RoleModel{
                Id       = repository.Id,
                Name     = repository.Name
            };
        }
    }
}
