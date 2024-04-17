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
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Products).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Users).WithMany(x => x.OrderDetails).HasForeignKey(x => x.UserID);
        }
    }
}
