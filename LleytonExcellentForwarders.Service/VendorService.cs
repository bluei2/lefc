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
    public class VendorService : IVendorService{
        protected LogisticDbContext _context { get; set; }
        public VendorService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(VendorModel model){
            var repository = model.ToRepository();

            _context.Vendors.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(VendorModel model){
            var repository = _context.Vendors.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Vendors.SingleOrDefault(x => x.Id == id).IsDeleted = true;
            await _context.SaveChangesAsync();
        }
        public async Task<VendorModel> GetAsync(Guid? id){
            var repository = await _context.Vendors.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<VendorModel>> GetAllAsync(){
            var model = await _context.Vendors
                .Where(x => x.IsDeleted == false)
                .Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
