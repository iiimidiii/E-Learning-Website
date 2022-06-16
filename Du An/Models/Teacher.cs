using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Bangdiems = new HashSet<Bangdiem>();
            LoginGvs = new HashSet<LoginGv>();
        }

        public string MaGv { get; set; } = null!;
        public string? TenGv { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? IdvaiTro { get; set; }
        public string? MaMh { get; set; }
        public int? IdnienKhoa { get; set; }
        public string? MaQuyenHan { get; set; }
        public string? MaLop { get; set; }

        public virtual Year? IdnienKhoaNavigation { get; set; }
        public virtual Role? IdvaiTroNavigation { get; set; }
        public virtual Class? MaLopNavigation { get; set; }
        public virtual Authorize? MaQuyenHanNavigation { get; set; }
        public virtual ICollection<Bangdiem> Bangdiems { get; set; }
        public virtual ICollection<LoginGv> LoginGvs { get; set; }
    }
}
