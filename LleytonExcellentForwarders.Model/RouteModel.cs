using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Model
{
    public class RouteModel{
        public Guid      Id              { get; set; }
        public string    Origin          { get; set; }
        public string    Destination     { get; set; }
        public string    Mode            { get; set; }
        public int       Distance        { get; set; }
    }
}
