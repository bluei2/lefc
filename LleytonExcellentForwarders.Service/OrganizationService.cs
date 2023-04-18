using LleytonExcellentForwarders.Entity.Dao;
using LleytonExcellentForwarders.Entity.Mapping;
using LleytonExcellentForwarders.Interface;
using LleytonExcellentForwarders.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Service
{
    public class OrganizationService : IOrganizationService
    {
        protected LogisticDbContext _context { get; set; }
        public OrganizationService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(OrganizationModel model){
            var repository = model.ToRepository();

            _context.Organizations.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(OrganizationModel model){
            var repository = _context.Organizations.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Organizations.SingleOrDefault(x => x.Id == id).IsDeleted = true;
            await _context.SaveChangesAsync();
        }
        public async Task<OrganizationModel> GetAsync(Guid? id){
            var repository = await _context.Organizations.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<OrganizationModel>> GetAllAsync(){
            var model = await _context.Organizations
                .Where(x => x.IsDeleted == false)
                .Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}