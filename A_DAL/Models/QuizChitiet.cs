using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class QuizChitiet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SoluongCauhoi { get; set; }
        public string Mota { get; set; }
        // public virtual Quiz LoaiQuiz { get; set; }
        public int DiemToida { get; set; }
        public int TrangThai { get; set; }
    }
}
