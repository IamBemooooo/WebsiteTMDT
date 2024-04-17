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
    public class SaleConfig : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.SaleName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.TimeEnd);
            builder.Property(x => x.TimeStart);
            builder.HasOne(x => x.SaleTypes).WithMany(x => x.Sale).HasForeignKey(x => x.SaleTypeId);
        }
    }
}
