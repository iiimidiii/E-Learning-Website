using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class LoginGv
    {
        public int IdLoginGv { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? MaGv { get; set; }

        public virtual GiaoVien? MaGvNavigation { get; set; }
    }
}
