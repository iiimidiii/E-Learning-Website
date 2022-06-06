using System;
using System.Collections.Generic;

namespace Du_An.Models
{
    public partial class LoginL
    {
        public string IdLoginLs { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int MaLs { get; set; }

        public virtual Leadership MaLsNavigation { get; set; } = null!;
    }
}
