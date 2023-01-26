using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        //public int QuantityPerUnit {get; set;}
        [MaxLength(50)]
        public string Barcode { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }//değer tip - referans tip nedir araştır / pointer nedir araştır/
                                            //nesne referanslarımız nasıl bir değer tutar araştır(nullable value types)
                                            //sqp stored procedures,mvc
        public int UnitsInOrder { get; set; }
        



        

    }
}
