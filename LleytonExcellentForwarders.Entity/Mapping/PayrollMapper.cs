using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class PayrollMapper
    {
        public static PayrollRepository ToRepository(this PayrollModel model){
            return new PayrollRepository{
                Id          = model.Id,
                PayDate     = model.PayDate,
                DateFrom    = model.DateFrom,
                DateTo      = model.DateTo,
                Total       = model.Total
            };
        }
        public static PayrollModel ToModel(this PayrollRepository repository){
            return new PayrollModel{
                Id          = repository.Id,
                PayDate     = repository.PayDate,
                DateFrom    = repository.DateFrom,
                DateTo      = repository.DateTo,
                Total       = repository.Total
            };
        }
    }
}
