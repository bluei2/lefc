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
    public class RouteService : IRouteService{
        protected LogisticDbContext _context { get; set; }
        public RouteService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(RouteModel model){
            var repository = model.ToRepository();

            _context.Routes.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(RouteModel model){
            var repository = _context.Routes.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Routes.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<RouteModel> GetAsync(Guid? id){
            var repository = await _context.Routes.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<RouteModel>> GetAllAsync(){
            var model = await _context.Routes.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
