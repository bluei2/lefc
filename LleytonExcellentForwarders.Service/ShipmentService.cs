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
    public class ShipmentService : IShipmentService{
        protected LogisticDbContext _context { get; set; }
        public ShipmentService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(ShipmentModel model){
            var repository = model.ToRepository();

            _context.Shipments.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(ShipmentModel model){
            var repository = _context.Shipments.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Shipments.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<ShipmentModel> GetAsync(Guid? id){
            var repository = await _context.Shipments.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<ShipmentModel>> GetAllAsync(){
            var model = await _context.Shipments.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
