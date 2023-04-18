using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface ICustomerService
    {
        Task<Guid>                  CreateAsync(CustomerModel model);
        Task                        EditAsync(CustomerModel model);
        Task                        DeleteAsync(Guid? id);
        Task<CustomerModel>         GetAsync(Guid? id);
        Task<List<CustomerModel>>   GetAllAsync();
    }
}
