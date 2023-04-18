using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface IOrganizationService
    {
        Task<Guid>                       CreateAsync(OrganizationModel model);
        Task                             EditAsync(OrganizationModel model);
        Task                             DeleteAsync(Guid? id);
        Task<OrganizationModel>          GetAsync(Guid? id);
        Task<List<OrganizationModel>>    GetAllAsync();
    }
}