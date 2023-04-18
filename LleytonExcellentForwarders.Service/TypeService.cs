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
    public class TypeService : ITypeService{
        protected LogisticDbContext _context { get; set; }
        public TypeService(LogisticDbContext context){
            _context = context;
        }
        public async Task<TypeModel> GetAsync(Guid? id){
            var repository = await _context.Types.SingleOrDefaultAsync(x => x.Id == id);
            return repository.ToModel();
        }
        public async Task<List<TypeModel>> GetAllAsync(){
            var model = await _context.Types.Select(x => x.ToModel()).ToListAsync();
            return model;
        }
    }
}
