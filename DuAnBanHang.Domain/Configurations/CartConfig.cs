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
    public class CartConfig : IEntityTypeConfiguration<Carts>
    {
        public void Configure(EntityTypeBuilder<Carts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TotalMoney).HasDefaultValue(0);
            builder.HasOne(x => x.Users).WithOne(x => x.Carts).HasForeignKey<Carts>(x => x.UserID).IsRequired();
        }
    }
}
