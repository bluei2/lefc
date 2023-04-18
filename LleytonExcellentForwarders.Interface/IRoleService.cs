using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IRoleService
    {
        Task<Guid>                   CreateAsync(RoleModel model);
        Task                         EditAsync(RoleModel model);
        Task                         DeleteAsync(Guid? id);
        Task<RoleModel>              GetAsync(Guid? id);
        Task<List<RoleModel>>        GetAllAsync();
    }
}
