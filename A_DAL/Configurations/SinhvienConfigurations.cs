using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    internal class SinhvienConfigurations : IEntityTypeConfiguration<Sinhvien>
    {
        public void Configure(EntityTypeBuilder<Sinhvien> builder)
        {
            builder.ToTable("SinhVien"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính
            // Cấu hình dữ liệu
            builder.Property(p => p.Name).HasColumnName("TenSV").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.MaSv).HasColumnName("MaSV").
                HasColumnType("varchar(30)").IsRequired(); // varchar(30) not null
            builder.Property(p => p.Email).HasColumnName("EmailSV").
                HasColumnType("varchar(100)").IsRequired(); // varchar(100) not null
            builder.Property(p => p.Chuyennganh).HasColumnName("ChuyenNganh").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.Nganh).HasColumnName("Nganh").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null

        }
    }
}
