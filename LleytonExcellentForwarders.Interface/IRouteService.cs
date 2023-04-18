using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IRouteService
    {
        Task<Guid>                   CreateAsync(RouteModel model);
        Task                         EditAsync(RouteModel model);
        Task                         DeleteAsync(Guid? id);
        Task<RouteModel>             GetAsync(Guid? id);
        Task<List<RouteModel>>       GetAllAsync();
    }
}
