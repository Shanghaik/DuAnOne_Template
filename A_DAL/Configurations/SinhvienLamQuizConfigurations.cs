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
    internal class SinhvienLamQuizConfigurations : IEntityTypeConfiguration<SinhvienLamQuiz>

    {
        public void Configure(EntityTypeBuilder<SinhvienLamQuiz> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(k => k.IdSV).IsRequired();
            builder.Property(k => k.IdQuizChitiet).IsRequired();
            //builder.Property(k => k.Result).HasColumnType("double");
            builder.Property(k => k.TakeQuizTime).HasColumnType("Datetime");
            // Set khóa ngoại
            builder.HasOne(x => x.Sinhvien)
            .WithMany().HasForeignKey(p => p.IdSV);
            builder.HasOne(x => x.QuizChitiet)
            .WithMany().HasForeignKey(p => p.IdQuizChitiet);

        }
    }
}
