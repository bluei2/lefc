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
    public class VehicleService : IVehicleService{
        protected LogisticDbContext _context { get; set; }
        public VehicleService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(VehicleModel model){
            var repository = model.ToRepository();

            _context.Vehicles.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(VehicleModel model){
            var repository = _context.Vehicles.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Vehicles.SingleOrDefault(x => x.Id == id).IsDeleted = true;
            await _context.SaveChangesAsync();
        }
        public async Task<VehicleModel> GetAsync(Guid? id){
            var repository = await _context.Vehicles.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<VehicleModel>> GetAllAsync(){
            var model = await _context.Vehicles
                .Where(x => x.IsDeleted == false)
                .Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
