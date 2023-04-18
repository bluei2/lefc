using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Interface
{
    public interface ITransactionService
    {
        Task<Guid>                       CreateAsync(TransactionModel model);
        Task                             EditAsync(TransactionModel model);
        Task                             DeleteAsync(Guid? id);
        Task<TransactionModel>           GetAsync(Guid? id);
        Task<List<TransactionModel>>     GetAllAsync();
    }
}
