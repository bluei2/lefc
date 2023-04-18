using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IFreightService
    {
        Task<Guid>                       CreateAsync(FreightModel model);
        Task                             EditAsync(FreightModel model);
        Task                             DeleteAsync(Guid? id);
        Task<FreightModel>               GetAsync(Guid? id);
        Task<List<FreightModel>>         GetAllAsync();
    }
}
