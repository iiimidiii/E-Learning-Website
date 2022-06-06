using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class LoginH
    {
        public int IdloginHs { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string MaHs { get; set; } = null!;

        public virtual HocSinh MaHsNavigation { get; set; } = null!;
    }
}
