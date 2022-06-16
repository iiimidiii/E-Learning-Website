using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class Role
    {
        public Role()
        {
            GiaoViens = new HashSet<Teacher>();
        }

        public string IdvaiTro { get; set; } = null!;
        public string? TenVaiTro { get; set; }

        public virtual ICollection<Teacher> GiaoViens { get; set; }
    }
}
