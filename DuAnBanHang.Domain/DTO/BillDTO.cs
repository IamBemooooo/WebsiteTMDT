using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class BillDTO
    {
        public Guid BillCode { get; set; }
        public string CustomerName { get; set; } // Chính là tên của User khi login 
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public decimal TotalMoney { get; set; }
    }
}
