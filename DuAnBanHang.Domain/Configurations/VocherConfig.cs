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
    public class VocherConfig : IEntityTypeConfiguration<Vouchers>
    {
        public void Configure(EntityTypeBuilder<Vouchers> builder)
        {
            builder.ToTable("Vocher");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Bills).WithMany(x => x.Vouchers).HasForeignKey(x => x.BillID);
            builder.HasOne(x => x.VoucherTypes).WithMany(x => x.Vocher).HasForeignKey(x => x.VocherTypeID);
            builder.Property(x => x.VocherName).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.TimeStart);
            builder.Property(x => x.TimeEnd);
        }
    }
}
