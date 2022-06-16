using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Year
    {
        public Year()
        {
            GiaoViens = new HashSet<Teacher>();
            HocSinhs = new HashSet<Student>();
        }

        public int IdnienKhoa { get; set; }
        public string? NienKhoa1 { get; set; }

        public virtual ICollection<Teacher> GiaoViens { get; set; }
        public virtual ICollection<Student> HocSinhs { get; set; }
    }
}
