using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class QuyenHan
    {
        public QuyenHan()
        {
            GiaoViens = new HashSet<GiaoVien>();
            Leaderships = new HashSet<Leadership>();
        }

        public string MaQuyenHan { get; set; } = null!;
        public string? TenQuyenHan { get; set; }
        public string? ChiTietQuyenHan { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
        public virtual ICollection<Leadership> Leaderships { get; set; }
    }
}
