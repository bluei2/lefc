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
    public class RoleService : IRoleService{
        protected LogisticDbContext _context { get; set; }
        public RoleService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(RoleModel model){
            var repository = model.ToRepository();

            _context.Roles.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(RoleModel model){
            var repository = _context.Roles.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Roles.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<RoleModel> GetAsync(Guid? id){
            var repository = await _context.Roles.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<RoleModel>> GetAllAsync(){
            var model = await _context.Roles.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
