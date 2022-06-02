using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class VaiTroGiaoVien
    {
        public VaiTroGiaoVien()
        {
            GiaoViens = new HashSet<GiaoVien>();
        }

        public string IdvaiTro { get; set; } = null!;
        public string? TenVaiTro { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }
}
