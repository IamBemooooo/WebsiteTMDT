using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class BillDetailDTO
    {
        public Guid BillCode { get; set; }
        public string CustomerName { get; set; } // Chính là tên của User khi login 
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public string ProductName { get; set; }
        public int NumberOfProduct { get; set; }
        public decimal price { get; set; }
        public decimal TotalMoney { get; set; }
        public string VocherName { get; set; }
    }
}
