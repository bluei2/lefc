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
    public class TransactionService : ITransactionService{
        protected LogisticDbContext _context { get; set; }
        public TransactionService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(TransactionModel model){
            var repository = model.ToRepository();

            _context.Transactions.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(TransactionModel model){
            var repository = _context.Transactions.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Transactions.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<TransactionModel> GetAsync(Guid? id){
            var repository = await _context.Transactions.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<TransactionModel>> GetAllAsync(){
            var model = await _context.Transactions.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
