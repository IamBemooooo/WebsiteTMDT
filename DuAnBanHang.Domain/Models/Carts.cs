using DuAnBanHang.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Models
{
    public class Carts
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public decimal TotalMoney { get; set; } // Tổng tiền toàn bộ giỏ hàng 
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // ForeignKey 
        public virtual Users Users { get; set; }
        public virtual ICollection<CartDetails>? CartDetails { get; set; }
    }
}
