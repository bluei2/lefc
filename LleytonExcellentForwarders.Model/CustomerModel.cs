using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class CustomerModel{
        public Guid      Id          { get; set; }
        public string    Code        { get; set; }
        public string    Name        { get; set; }
        public string    Address     { get; set; }
        public bool      IsDeleted   { get; set; }
    }
}
