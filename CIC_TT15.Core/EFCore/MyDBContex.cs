using CIC_TT15.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CIC_TT15.Core.EFCore
{
    public class MyDBContex : DbContext
    {
        public DbSet<D10_TOCHUC>? D10_TOCHUCs { get; set; }
        public DbSet<D10_TOCHUC_TC024>? D10_TOCHUC_TC024s { get; set; }
        public DbSet<D32_CHOVAY>? D32_CHOVAYs { get; set; }
        public DbSet<D32_CHOVAY_KHEUOC>? D32_CHOVAY_KHEUOCs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id=CIC_ANHDD;Password=1911;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=CIC_TT15)));");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D32_CHOVAY>(e =>
            {
                e.ToTable("D32_CHOVAY");
                e.HasKey(k => new { k.YYYYMMDD, k.TTC01, k.TTC02, k.HD001 });
                e.Property(d => d.TTC02).IsRequired().HasComment("Tên chi nhánh TCTD");
                e.Property(d => d.HD004).HasPrecision(3).HasComment("Thời hạn cấp tín dụng (ngày)"); // 3 là tổng số chữ số
                e.Property(d => d.HD005).HasPrecision(1).HasComment("Trạng thái Tài sản bảo đảm (TSBĐ)"); 
            });

            modelBuilder.Entity<D32_CHOVAY_KHEUOC>(e =>
            {
                e.ToTable("D32_CHOVAY_KHEUOC");
                e.HasKey(k => new { k.YYYYMMDD, k.TTC01, k.TTC03, k.HD001, k.KU001 });
                e.Property(d => d.KU009).HasDefaultValue("00").HasComment("Mã tiền tệ");
                //e.Property(d => d.KU004).HasColumnType("NUMBER(2)").HasComment("Hoạt động cấp tín dụng bằng phương tiện điện tử");
                e.Property(d => d.KU010).HasPrecision(18, 2).HasComment("Số dư nợ theo nguyên tệ"); // 18 là tổng số chữ số, 2 là số chữ số thập phân
                e.Property(d => d.KU011).HasConversion<decimal?>().HasComment("Lãi suất");
                e.HasOne(d => d.d32_CHOVAY)
                .WithMany(d => d.D32_CHOVAY_KHEUOCs)
                .HasForeignKey(d => new { d.YYYYMMDD, d.TTC01, d.TTC03, d.HD001 })
                .HasConstraintName("FK_D32_CHOVAY_KHEUOC__D32_CHOVAY");
            });

        }
    }
}
