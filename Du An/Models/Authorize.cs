using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Authorize
    {
        public Authorize()
        {
            GiaoViens = new HashSet<Teacher>();
            Leaderships = new HashSet<Leadership>();
        }

        public string MaQuyenHan { get; set; } = null!;
        public string? TenQuyenHan { get; set; }
        public string? ChiTietQuyenHan { get; set; }

        public virtual ICollection<Teacher> GiaoViens { get; set; }
        public virtual ICollection<Leadership> Leaderships { get; set; }
    }
}
