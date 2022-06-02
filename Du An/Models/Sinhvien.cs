using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Sinhvien
    {
        public Sinhvien()
        {
            LoginSvs = new HashSet<LoginSv>();
        }

        public string MaSv { get; set; } = null!;
        public string? TenSv { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Gvcn { get; set; }
        public int? IdnienKhoa { get; set; }
        public string MaLop { get; set; } = null!;
        public string? MaMh { get; set; }

        public virtual NienKhoa? IdnienKhoaNavigation { get; set; }
        public virtual Lop MaLopNavigation { get; set; } = null!;
        public virtual Monhoc? MaMhNavigation { get; set; }
        public virtual Bangdiem Bangdiem { get; set; } = null!;
        public virtual ICollection<LoginSv> LoginSvs { get; set; }
    }
}
