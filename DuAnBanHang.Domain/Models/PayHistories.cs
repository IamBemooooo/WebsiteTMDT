using DuAnBanHang.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Models
{
    public class PayHistories // là lớp trung gian giữa Hình thức thanh toán với hóa đơn => mqh n-n 
    {
        public Guid Id { get; set; }
        public Guid PaymentExpressionID { get; set; }
        public Guid BillID { get; set; }
        public DateTime TimePay { get; set; }
        public decimal MoneyPayed { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // ForeignKey 
        public virtual PaymentExpressions? PaymentExpressions { get; set; }
        public virtual Bills? Bills { get; set; }
    }
}
