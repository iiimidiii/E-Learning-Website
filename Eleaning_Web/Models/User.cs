using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class User
    {
        public User()
        {
            Results = new HashSet<Result>();
        }

        public string UserId { get; set; } = null!;
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public bool? Gender { get; set; }
        public string? Images { get; set; }
        public int? RoleId { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
