using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Organization")]
    public class OrganizationRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id                  { get; set; }
        public string    Name                { get; set; }
        public string    Abbreviation        { get; set; }
        public string    Branch              { get; set; }
        public string    Owner               { get; set; }
        public string    Address             { get; set; }
        public string    Telephone           { get; set; }
        public string    Fax                 { get; set; }
        public string    Email               { get; set; }
        public string    Website             { get; set; }
        public bool      IsDeleted           { get; set; }
    }
}