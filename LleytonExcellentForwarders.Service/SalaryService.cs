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
    public class SalaryService : ISalaryService{
        protected LogisticDbContext _context { get; set; }
        public SalaryService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(SalaryModel model){
            var repository = model.ToRepository();

            _context.Salaries.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(SalaryModel model){
            var repository = _context.Salaries.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Salaries.SingleOrDefault(x => x.Id == id);
            await _context.SaveChangesAsync();
        }
        public async Task<SalaryModel> GetAsync(Guid? id){
            var repository = await _context.Salaries.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<SalaryModel>> GetAllAsync(){
            var model = await _context.Salaries.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
