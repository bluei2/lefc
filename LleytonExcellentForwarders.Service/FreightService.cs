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
    public class FreightService : IFreightService{
        protected LogisticDbContext _context { get; set; }
        public FreightService(LogisticDbContext context){
            _context = context;
        }

        public async Task<Guid> CreateAsync(FreightModel model){
            var repository = model.ToRepository();

            _context.Freights.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(FreightModel model){
            var repository = _context.Freights.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Freights.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<FreightModel> GetAsync(Guid? id){
            var repository = await _context.Freights.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<FreightModel>> GetAllAsync(){
            var model = await _context.Freights.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
