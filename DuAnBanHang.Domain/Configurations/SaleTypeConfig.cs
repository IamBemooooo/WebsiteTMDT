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
    public class SaleTypeConfig : IEntityTypeConfiguration<SaleTypes>
    {
        public void Configure(EntityTypeBuilder<SaleTypes> builder)
        {
            builder.ToTable("SaleType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.SaleTypeName).HasMaxLength(50).IsFixedLength().IsUnicode(true);

        }
    }
}
