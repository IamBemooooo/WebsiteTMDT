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
    public class VocherTypeConfig : IEntityTypeConfiguration<VoucherTypes>
    {
        public void Configure(EntityTypeBuilder<VoucherTypes> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.VocherTypeName).HasMaxLength(50).IsFixedLength();

        }
    }
}
