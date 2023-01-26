using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDto
    {
        [DisplayName("Ürün İsmi")]
        public string? ProductName { get; set; }

        [MaxLength(50)]//bunları modelde vereceğim
        public string? Barcode { get; set;}
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsInOrder { get; set; }
    }
}
