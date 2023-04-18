using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class VendorMapper{
        public static VendorRepository ToRepository(this VendorModel model){
            return new VendorRepository{
                Id             = model.Id,
                Code           = model.Code,
                Name           = model.Name,
                Abbreviation   = model.Abbreviation,
                Branch         = model.Branch,
                Contact        = model.Contact,
                Address        = model.Address,
                Telephone      = model.Telephone,
                Fax            = model.Fax,
                Email          = model.Email,
                Website        = model.Website
            };
        }
        public static VendorModel ToModel(this VendorRepository repository){
            return new VendorModel{
                Id             = repository.Id,
                Code           = repository.Code,
                Name           = repository.Name,
                Abbreviation   = repository.Abbreviation,
                Branch         = repository.Branch,
                Contact        = repository.Contact,
                Address        = repository.Address,
                Telephone      = repository.Telephone,
                Fax            = repository.Fax,
                Email          = repository.Email,
                Website        = repository.Website
            };
        }
    }
}
