using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class SaleDetailDTO
    {
        public string SaleType { get; set; }
        public string SaleName { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string NameProduct { get; set; }
        public decimal Discount { get; set; }
        public int CountProduct { get; set; }
    }
}
