using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Subject
    {
        public Subject()
        {
            HocSinhs = new HashSet<Student>();
        }

        public string MaMh { get; set; } = null!;
        public string? TenMh { get; set; }

        public virtual ICollection<Student> HocSinhs { get; set; }
    }
}
