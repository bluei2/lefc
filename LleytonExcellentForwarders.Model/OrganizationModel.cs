using System;
using System.Collections.Generic;

namespace LleytonExcellentForwarders.Model
{
    public class OrganizationModel {
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