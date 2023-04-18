using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class WageMapper{
        public static WageRepository ToRepository(this WageModel model){
            return new WageRepository{
                Id               = model.Id,
                PayrollId        = model.PayrollId,
                EmployeeId       = model.EmployeeId,
                Rate             = model.Rate,
                Allowance        = model.Allowance,
                Reimbursement    = model.Reimbursement,
                Description      = model.Description,
                Total            = model.Total,
                Sss              = model.Sss,
                Philhealth       = model.Philhealth,
                Pagibig          = model.Pagibig,
                Loan             = model.Loan,
                Advance          = model.Advance,
                Product          = model.Product,
                Item             = model.Item,
                Damage           = model.Damage,
                Other            = model.Other,
                Detail           = model.Detail,
                Deduction        = model.Deduction,
                NetPay           = model.NetPay
            };
        }
        public static WageModel ToModel(this WageRepository repository){
            return new WageModel{
                Id               = repository.Id,
                PayrollId        = repository.PayrollId,
                EmployeeId       = repository.EmployeeId,
                Rate             = repository.Rate,
                Allowance        = repository.Allowance,
                Reimbursement    = repository.Reimbursement,
                Description      = repository.Description,
                Total            = repository.Total,
                Sss              = repository.Sss,
                Philhealth       = repository.Philhealth,
                Pagibig          = repository.Pagibig,
                Loan             = repository.Loan,
                Advance          = repository.Advance,
                Product          = repository.Product,
                Item             = repository.Item,
                Damage           = repository.Damage,
                Other            = repository.Other,
                Detail           = repository.Detail,
                Deduction        = repository.Deduction,
                NetPay           = repository.NetPay
            };
        }
    }
}
