using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface ISalaryService
    {
        Task<Guid>                   CreateAsync(SalaryModel model);
        Task                         EditAsync(SalaryModel model);
        Task                         DeleteAsync(Guid? id);
        Task<SalaryModel>            GetAsync(Guid? id);
        Task<List<SalaryModel>>      GetAllAsync();
    }
}
