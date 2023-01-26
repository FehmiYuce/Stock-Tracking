using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Territory
    {
        [Key]
        public int TerritoryId { get; set; }
        public string? RegionId { get; set; }
        public string? Description { get; set; }
        
    }
}
