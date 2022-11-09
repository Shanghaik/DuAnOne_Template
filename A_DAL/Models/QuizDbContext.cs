using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class QuizDbContext :DbContext
    {
        public QuizDbContext()
        {
        }
        public QuizDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=SHANGHAIK\\SQLEXPRESS;Initial Catalog=DuanMau_01;" +
                "Persist Security Info=True;User ID=shanghaik;Password=123"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
