using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IRateService
    {
        Task<Guid>                   CreateAsync(RateModel model);
        Task                         EditAsync(RateModel model);
        Task                         DeleteAsync(Guid? id);
        Task<RateModel>              GetAsync(Guid? id);
        Task<List<RateModel>>        GetAllAsync();
    }
}
