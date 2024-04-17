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
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TotalMoney).HasDefaultValue(0);
            builder.Property(x => x.NumberOfProduct).HasDefaultValue(0);
            builder.HasOne(x => x.Carts).WithMany(x => x.CartDetails).HasForeignKey(x => x.CartID);
            builder.HasOne(x => x.Products).WithMany(x => x.CartDetails).HasForeignKey(x => x.ProductID);
        }
    }
}
