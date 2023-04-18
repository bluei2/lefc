using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IVendorService
    {
        Task<Guid>                   CreateAsync(VendorModel model);
        Task                         EditAsync(VendorModel model);
        Task                         DeleteAsync(Guid? id);
        Task<VendorModel>            GetAsync(Guid? id);
        Task<List<VendorModel>>      GetAllAsync();
    }
}
