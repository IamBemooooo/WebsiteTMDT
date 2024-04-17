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
    public class BillConfig : IEntityTypeConfiguration<Bills>
    {
        public void Configure(EntityTypeBuilder<Bills> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // tự gen id
                                                               // foreignKey
            builder.HasOne(x => x.Users).WithMany(x => x.Bills).HasForeignKey(x => x.UserID);
            builder.Property(x => x.SoldDate).HasColumnName("SoldDate");
        }
    }
}
