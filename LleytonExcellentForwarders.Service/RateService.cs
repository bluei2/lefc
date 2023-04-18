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
    public class RateService : IRateService{
        protected LogisticDbContext _context { get; set; }
        public RateService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(RateModel model){
            var repository = model.ToRepository();

            _context.Rates.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(RateModel model){
            var repository = _context.Rates.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Rates.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<RateModel> GetAsync(Guid? id){
            var repository = await _context.Rates.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<RateModel>> GetAllAsync(){
            var model = await _context.Rates.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
