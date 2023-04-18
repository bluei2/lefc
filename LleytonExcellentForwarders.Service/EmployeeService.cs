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
    public class EmployeeService : IEmployeeService{
        protected LogisticDbContext _context { get; set; }
        public EmployeeService(LogisticDbContext context){
            _context = context;
        }
        public async Task<Guid> CreateAsync(EmployeeModel model){
            var repository = model.ToRepository();

            _context.Employees.Add(repository);
            await _context.SaveChangesAsync();

            return repository.Id;
        }
        public async Task EditAsync(EmployeeModel model){
            var repository = _context.Employees.SingleOrDefault(x => x.Id == model.Id);

            _context.Entry(repository).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid? id){
            var repository = _context.Employees.SingleOrDefault(x => x.Id == id).IsDeleted = true;
            await _context.SaveChangesAsync();
        }
        public async Task<EmployeeModel> GetAsync(Guid? id){
            var repository = await _context.Employees.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<EmployeeModel>> GetAllAsync(){
            var model = await _context.Employees
                .Where(x => x.IsDeleted == false)
                .Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
