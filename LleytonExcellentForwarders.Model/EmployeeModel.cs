using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class EmployeeModel{
        public Guid      Id              { get; set; }
        public string    Name            { get; set; }
        public Guid      RoleId          { get; set; }
        public DateTime  Birthdate       { get; set; }
        public string    Address         { get; set; }
        public string    MobileNumber    { get; set; }
        public string    SssId           { get; set; }
        public decimal   SssRate         { get; set; }
        public string    PhilhealthId    { get; set; }
        public decimal   PhilhealthRate  { get; set; }
        public string    PagibigId       { get; set; }
        public decimal   PagibigRate     { get; set; }
        public decimal   Rate            { get; set; }
        public bool      IsDeleted       { get; set; }
    }
}
