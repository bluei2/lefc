using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Route")]
    public class RouteRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id          { get; set; }
        public string    Origin      { get; set; }
        public string    Destination { get; set; }
        public string    Mode        { get; set; }
        public int       Distance    { get; set; }
    }
}
