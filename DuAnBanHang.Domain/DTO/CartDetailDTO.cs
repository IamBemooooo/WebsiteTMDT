using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class CartDetailDTO
    {
        public string productName { get; set; }
        public List<string> image { get; set; }
        public decimal price { get; set; }
        public decimal NumberOfProduct { get; set; }
        public decimal TotalMoney { get; set; }

    }
}
