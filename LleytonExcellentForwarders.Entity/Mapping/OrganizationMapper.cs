using LleytonExcellentForwarders.Entity.Repository;
using LleytonExcellentForwarders.Model;

namespace LleytonExcellentForwarders.Entity.Mapping
{
    public static class OrganizationMapper
    {
        public static OrganizationRepository ToRepository(this OrganizationModel model){
            return new OrganizationRepository{
                Id               = model.Id,
                Name             = model.Name,
                Abbreviation     = model.Abbreviation,
                Branch           = model.Branch,
                Owner            = model.Owner,
                Address          = model.Address,
                Telephone        = model.Telephone,
                Fax              = model.Fax,
                Email            = model.Email,
                Website          = model.Website
            };
        }
        public static OrganizationModel ToModel(this OrganizationRepository repository){
            return new OrganizationModel{
                Id               = repository.Id,
                Name             = repository.Name,
                Abbreviation     = repository.Abbreviation,
                Branch           = repository.Branch,
                Owner            = repository.Owner,
                Address          = repository.Address,
                Telephone        = repository.Telephone,
                Fax              = repository.Fax,
                Email            = repository.Email,
                Website          = repository.Website
            };
        }
    }
}