using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Student
    {
        public Student()
        {
            LoginHs = new HashSet<LoginH>();
        }

        public string MaHs { get; set; } = null!;
        public string? TenHs { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Gvcn { get; set; }
        public int? IdnienKhoa { get; set; }
        public string MaLop { get; set; } = null!;
        public string? MaMh { get; set; }

        public virtual Year? IdnienKhoaNavigation { get; set; }
        public virtual Class MaLopNavigation { get; set; } = null!;
        public virtual Subject? MaMhNavigation { get; set; }
        public virtual Bangdiem Bangdiem { get; set; } = null!;
        public virtual ICollection<LoginH> LoginHs { get; set; }
    }
}
