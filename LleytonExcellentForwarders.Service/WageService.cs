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
    public class WageService : IWageService{
        protected LogisticDbContext _context { get; set; }
        public WageService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(WageModel model){
            var repository = model.ToRepository();

            _context.Wages.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(WageModel model){
            var repository = _context.Wages.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Wages.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<WageModel> GetAsync(Guid? id){
            var repository = await _context.Wages.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<WageModel>> GetAllAsync(){
            var model = await _context.Wages.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
