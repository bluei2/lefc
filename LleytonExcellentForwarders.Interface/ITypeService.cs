using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface ITypeService
    { 
        Task<TypeModel>       GetAsync(Guid? id);
        Task<List<TypeModel>> GetAllAsync();
    }
}
