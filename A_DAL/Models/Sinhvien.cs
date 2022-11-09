using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class Sinhvien
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MaSv { get; set; }
        public string Email { 
            get { return Email; } 
            set
            { // Set email bởi mã SV luôn
                Email = MaSv + "@fpt.edu.vn";
            }
        }
        public string Nganh { get; set; }
        public string Chuyennganh { get; set; }

    }
}
