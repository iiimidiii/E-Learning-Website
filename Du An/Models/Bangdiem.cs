using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Bangdiem
    {
        public string MaSv { get; set; } = null!;
        public string? MaMh { get; set; }
        public int? DiemChuyenCan { get; set; }
        public int? DiemMieng { get; set; }
        public int? Diem15p { get; set; }
        public int? DiemHs1 { get; set; }
        public int? DiemHs2 { get; set; }
        public int? DiemHs3 { get; set; }
        public int? DiemTb { get; set; }
        public string? MaGv { get; set; }

        public virtual GiaoVien? MaGvNavigation { get; set; }
        public virtual HocSinh MaSvNavigation { get; set; } = null!;
    }
}
