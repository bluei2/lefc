using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class VendorModel{
        public Guid      Id              { get; set; }
        public string    Code            { get; set; }
        public string    Name            { get; set; }
        public string    Abbreviation    { get; set; }
        public string    Branch          { get; set; }
        public string    Contact         { get; set; }
        public string    Address         { get; set; }
        public string    Telephone       { get; set; }
        public string    Fax             { get; set; }
        public string    Email           { get; set; }
        public string    Website         { get; set; }
        public bool      IsDeleted       { get; set; }
    }
}
