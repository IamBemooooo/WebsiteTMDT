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
    public class PaymentExpressionConfig : IEntityTypeConfiguration<PaymentExpressions>
    {
        public void Configure(EntityTypeBuilder<PaymentExpressions> builder)
        {
            builder.ToTable("PaymentExpressions:");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsFixedLength().IsUnicode(true);
        }
    }
}
