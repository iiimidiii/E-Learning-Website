using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Monhoc
    {
        public Monhoc()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        public string MaMh { get; set; } = null!;
        public string? TenMh { get; set; }

        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
