using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Entity.Repository
{
    [Table("Vehicle")]
    public class VehicleRepository{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid      Id              { get; set; }
        public string    Name            { get; set; }
        public string    PlateNumber     { get; set; }
        public Guid      TypeId          { get; set; }
        public bool      IsPremium       { get; set; }
        public bool      IsDeleted       { get; set; }
    }
}
