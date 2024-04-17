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
    public class FeedbackConfig : IEntityTypeConfiguration<Feedbacks>
    {
        public void Configure(EntityTypeBuilder<Feedbacks> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OrderDetails).WithOne(x => x.Feedbacks).HasForeignKey<Feedbacks>(x => x.OrderDetailID);
        }
    }
}
