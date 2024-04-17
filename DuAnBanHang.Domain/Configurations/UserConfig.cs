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
    public class UserConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.FullName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsFixedLength();
            builder.Property(x => x.Email).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Username).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Password).HasMaxLength(50).IsFixedLength();
            builder.HasOne(x => x.Roles).WithOne(x => x.Users).HasForeignKey<Users>(x => x.RoleID);

        }
    }
}
