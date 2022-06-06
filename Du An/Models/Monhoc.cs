using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Monhoc
    {
        public Monhoc()
        {
            HocSinhs = new HashSet<HocSinh>();
        }

        public string MaMh { get; set; } = null!;
        public string? TenMh { get; set; }

        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}
