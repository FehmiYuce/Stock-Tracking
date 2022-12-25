using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CategoryDto
    {
        [DisplayName("Kategori İsmi")]
        public string? CategoryName { get; set; }
    }
}
