using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class GiaoVien
    {
        public GiaoVien()
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

        public virtual NienKhoa? IdnienKhoaNavigation { get; set; }
        public virtual VaiTroGiaoVien? IdvaiTroNavigation { get; set; }
        public virtual Lop? MaLopNavigation { get; set; }
        public virtual QuyenHan? MaQuyenHanNavigation { get; set; }
        public virtual ICollection<Bangdiem> Bangdiems { get; set; }
        public virtual ICollection<LoginGv> LoginGvs { get; set; }
    }
}
