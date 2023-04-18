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
    public class FuelService : IFuelService{
        protected LogisticDbContext _context { get; set; }
        public FuelService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(FuelModel model){
            var repository = model.ToRepository();

            _context.Fuels.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(FuelModel model){
            var repository = _context.Fuels.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Fuels.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<FuelModel> GetAsync(Guid? id){
            var repository = await _context.Fuels.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<FuelModel>> GetAllAsync(){
            var model = await _context.Fuels.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
