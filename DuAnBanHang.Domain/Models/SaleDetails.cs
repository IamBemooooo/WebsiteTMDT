using DuAnBanHang.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Models
{
    public class SaleDetails
    {
        public Guid ID { get; set; }
        public Guid IdSale { get; set; }
        public Guid IdProduct { get; set; }
        public decimal Discount { get; set; }
        public int CountProduct { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // khóa ngoại 
        public virtual Sales? Sales { get; set; }
        public virtual Products? Products { get; set; }
    }
}
