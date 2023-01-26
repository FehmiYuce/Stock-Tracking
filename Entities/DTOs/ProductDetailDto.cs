using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public string BrandName { get; set; }
        public string Barcode { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsInOrder { get; set; }
    }
}
