using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class ProductDTO
    {
        public Guid ID { get; set; }
        public string? NameProduct { get; set; }
        public string? NameType { get; set; }
        public string? DescriptionProduct { get; set; }
        public decimal Price { get; set; }
        public List<string> Images { get; set; } = new List<string>();

    }
}
