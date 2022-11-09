using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class SinhvienLamQuiz
    {
        public Guid Id { get; set; }
        public Guid IdSV { get; set; }
        public Guid IdQuizChitiet { get; set; }
        public DateTime TakeQuizTime { get; set; }
        public double Result { get; set; }
        public virtual Sinhvien? Sinhvien { get; set; }
        public virtual QuizChitiet? QuizChitiet { get; set; }
    }
}
