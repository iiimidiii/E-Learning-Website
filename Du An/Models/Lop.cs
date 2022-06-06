using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Lop
    {
        public Lop()
        {
            GiaoViens = new HashSet<GiaoVien>();
            HocSinhs = new HashSet<HocSinh>();
        }

        public string MaLop { get; set; } = null!;
        public string? TenLop { get; set; }
        public string? PhongHoc { get; set; }
        public string? ChiTiet { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}
