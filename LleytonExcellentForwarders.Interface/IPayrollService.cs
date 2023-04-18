using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IPayrollService
    {
        Task<Guid>                   CreateAsync(PayrollModel model);
        Task                         EditAsync(PayrollModel model);
        Task                         DeleteAsync(Guid? id);
        Task<PayrollModel>           GetAsync(Guid? id);
        Task<List<PayrollModel>>     GetAllAsync();
    }
}
