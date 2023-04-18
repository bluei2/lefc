using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IShipmentService
    {
        Task<Guid>                       CreateAsync(ShipmentModel model);
        Task                             EditAsync(ShipmentModel model);
        Task                             DeleteAsync(Guid? id);
        Task<ShipmentModel>              GetAsync(Guid? id);
        Task<List<ShipmentModel>>        GetAllAsync();
    }
}
