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
    public class BillDetailsConfig : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.ToTable("BillDetail");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Bills).WithMany(x => x.BillDetails).HasForeignKey(x => x.BillID);
            builder.HasOne(x => x.Products).WithMany(x => x.BillDetails).HasForeignKey(x => x.ProductID);
            builder.Property(x => x.NumberOfProduct).HasColumnName("NumberOfProduct").HasDefaultValue(0);
        }
    }
}
