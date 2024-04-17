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
    public class SaleDetailConfig : IEntityTypeConfiguration<SaleDetails>
    {
        public void Configure(EntityTypeBuilder<SaleDetails> builder)
        {
            builder.ToTable("SaleDetails");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Discount).HasDefaultValue(0);
            builder.Property(x => x.CountProduct).HasDefaultValue(0);
            builder.HasOne(x => x.Sales).WithMany(x => x.SaleDetails).HasForeignKey(x => x.IdSale);
            builder.HasOne(x => x.Products).WithMany(x => x.SaleDetails).HasForeignKey(x => x.IdProduct);
        }
    }
}
