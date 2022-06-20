using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class Class
    {
        public string ClassId { get; set; } = null!;
        public string? NameClass { get; set; }
        public string? Link { get; set; }
        public int? Amount { get; set; }
        public bool? Status { get; set; }
        public string? SubjectId { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
