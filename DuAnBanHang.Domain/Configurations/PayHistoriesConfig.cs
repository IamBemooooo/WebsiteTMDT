using DuAnBanHang.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Configurations
{
    public class PayHistoriesConfig : IEntityTypeConfiguration<PayHistories>
    {
        public void Configure(EntityTypeBuilder<PayHistories> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TimePay);
            builder.Property(x => x.MoneyPayed);
            builder.HasOne(x => x.PaymentExpressions).WithMany(x => x.PayHistories).HasForeignKey(x => x.PaymentExpressionID);
            builder.HasOne(x => x.Bills).WithMany(x => x.PayHistories).HasForeignKey(x => x.BillID);
        }
    }
}
