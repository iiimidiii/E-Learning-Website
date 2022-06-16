using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Class
    {
        public Class()
        {
            GiaoViens = new HashSet<Teacher>();
            HocSinhs = new HashSet<Student>();
        }

        public string MaLop { get; set; } = null!;
        public string? TenLop { get; set; }
        public string? PhongHoc { get; set; }
        public string? ChiTiet { get; set; }

        public virtual ICollection<Teacher> GiaoViens { get; set; }
        public virtual ICollection<Student> HocSinhs { get; set; }
    }
}
