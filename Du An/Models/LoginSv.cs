using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class LoginSv
    {
        public int IdloginSv { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string MaSv { get; set; } = null!;

        public virtual Sinhvien MaSvNavigation { get; set; } = null!;
    }
}
