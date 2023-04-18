using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IVehicleService
    {
        Task<Guid>                       CreateAsync(VehicleModel model);
        Task                             EditAsync(VehicleModel model);
        Task                             DeleteAsync(Guid? id);
        Task<VehicleModel>               GetAsync(Guid? id);
        Task<List<VehicleModel>>         GetAllAsync();
    }
}
