using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Leadership
    {
        public Leadership()
        {
            LoginLs = new HashSet<LoginL>();
        }

        public int MaLs { get; set; }
        public string? TenLs { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? ChucVu { get; set; }
        public string? MaQuyenHan { get; set; }

        public virtual QuyenHan? MaQuyenHanNavigation { get; set; }
        public virtual ICollection<LoginL> LoginLs { get; set; }
    }
}
