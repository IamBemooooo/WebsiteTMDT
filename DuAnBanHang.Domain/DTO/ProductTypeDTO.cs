using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class ProductTypeDTO
    {
        public Guid ID { get; set; }
        public string ProductsTypeName { get; set; } = string.Empty;
    }
}
