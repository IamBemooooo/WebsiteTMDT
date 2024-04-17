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
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductTypes>
    {
        public void Configure(EntityTypeBuilder<ProductTypes> builder)
        {
            builder.ToTable("ProductType");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.ProductsTypeName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
        }
    }
}
