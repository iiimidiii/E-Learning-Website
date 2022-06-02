using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class NienKhoa
    {
        public NienKhoa()
        {
            GiaoViens = new HashSet<GiaoVien>();
            Sinhviens = new HashSet<Sinhvien>();
        }

        public int IdnienKhoa { get; set; }
        public string? NienKhoa1 { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
