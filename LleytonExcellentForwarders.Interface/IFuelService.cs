using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IFuelService
    {
        Task<Guid>                   CreateAsync(FuelModel model);
        Task                         EditAsync(FuelModel model);
        Task                         DeleteAsync(Guid? id);
        Task<FuelModel>              GetAsync(Guid? id);
        Task<List<FuelModel>>        GetAllAsync();
    }
}
