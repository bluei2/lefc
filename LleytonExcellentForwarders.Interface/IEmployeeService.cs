using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IEmployeeService
    {
        Task<Guid>                       CreateAsync(EmployeeModel model);
        Task                             EditAsync(EmployeeModel model);
        Task                             DeleteAsync(Guid? id);
        Task<EmployeeModel>              GetAsync(Guid? id);
        Task<List<EmployeeModel>>        GetAllAsync();
    }
}
