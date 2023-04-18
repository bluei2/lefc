using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class SalaryModel{
        public Guid      Id          { get; set; }
        public Guid      RouteId     { get; set; }
        public Guid      TypeId      { get; set; }
        public Guid      RoleId      { get; set; }
        public decimal   Amount      { get; set; }
    }
}
