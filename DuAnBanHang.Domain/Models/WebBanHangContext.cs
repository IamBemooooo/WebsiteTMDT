using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DuAnBanHang.Domain.Models
{
    public partial class WebBanHangContext : DbContext
    {
        public WebBanHangContext()
        {
        }

        public WebBanHangContext(DbContextOptions<WebBanHangContext> options)
            : base(options)
        {
        }
        public DbSet<BillDetails> BillDetail { get; set; }
        public DbSet<Bills> Bill { get; set; }
        public DbSet<Carts> Cart { get; set; }
        public DbSet<CartDetails> CartDetail { get; set; }
        public DbSet<PayHistories> PayHistory { get; set; }
        public DbSet<PaymentExpressions> PaymentExpression { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<ProductTypes> ProductType { get; set; }
        public DbSet<Sales> Sale { get; set; }
        public DbSet<SaleDetails> SaleDetail { get; set; }
        public DbSet<SaleTypes> SaleType { get; set; }
        public DbSet<Vouchers> Vocher { get; set; }
        public DbSet<VoucherDetails> VocherDetail { get; set; }
        public DbSet<VoucherTypes> VocherType { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Roles> Role { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=WebBanHang;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
