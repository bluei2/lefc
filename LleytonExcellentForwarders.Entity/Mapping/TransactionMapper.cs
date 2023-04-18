using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class TransactionMapper{
        public static TransactionRepository ToRepository(this TransactionModel model){
            return new TransactionRepository{
                Id                   = model.Id,
                OrganizationId       = model.OrganizationId,
                VendorId             = model.VendorId,
                ReferrenceNumber     = model.ReferrenceNumber,
                TransactionDate      = model.TransactionDate,
                TransactionType      = model.TransactionType,
                Term                 = model.Term
            };
        }
        public static TransactionModel ToModel(this TransactionRepository repository){
            return new TransactionModel{
                Id                   = repository.Id,
                OrganizationId       = repository.OrganizationId,
                VendorId             = repository.VendorId,
                ReferrenceNumber     = repository.ReferrenceNumber,
                TransactionDate      = repository.TransactionDate,
                TransactionType      = repository.TransactionType,
                Term                 = repository.Term
            };
        }
    }
}
