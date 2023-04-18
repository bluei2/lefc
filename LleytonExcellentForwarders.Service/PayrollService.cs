using LleytonExcellentForwarders.Entity.Dao;
using LleytonExcellentForwarders.Entity.Mapping;
using LleytonExcellentForwarders.Interface;
using LleytonExcellentForwarders.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Service
{
    public class PayrollService : IPayrollService
    {
        protected LogisticDbContext _context { get; set; }
        public PayrollService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(PayrollModel model){
            var repository = model.ToRepository();

            _context.Payrolls.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(PayrollModel model){
            var repository = _context.Payrolls.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Payrolls.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<PayrollModel> GetAsync(Guid? id){
            var repository = await _context.Payrolls.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<PayrollModel>> GetAllAsync(){
            var model = await _context.Payrolls.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
