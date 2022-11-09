using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_DAL.Configurations
{
    internal class QuizChitietConfigurations : IEntityTypeConfiguration<QuizChitiet>
    {
        public void Configure(EntityTypeBuilder<QuizChitiet> builder)
        {
            builder.ToTable("QuizChitiet"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính
            // Cấu hình dữ liệu
            builder.Property(p => p.Name).HasColumnName("TenQuiz").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.Mota).HasColumnName("Description").
                HasColumnType("nvarchar(300)"); // varchar(30) not null
            builder.Property(p => p.DiemToida).HasColumnName("MaxGrade").
                HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.SoluongCauhoi).HasColumnName("Socauhoi").
                HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.StartTime).HasColumnName("Batdau").
                HasColumnType("Datetime").IsRequired();
            builder.Property(p => p.EndTime).HasColumnName("Ketthuc").
                HasColumnType("Datetime").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnName("Trangthai").
                HasColumnType("int").IsRequired();
        }
    }
}
