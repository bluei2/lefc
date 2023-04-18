using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IWageService
    {
        Task<Guid>                   CreateAsync(WageModel model);
        Task                         EditAsync(WageModel model);
        Task                         DeleteAsync(Guid? id);
        Task<WageModel>              GetAsync(Guid? id);
        Task<List<WageModel>>        GetAllAsync();
    }
}
