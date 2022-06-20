using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class Result
    {
        public string ResultId { get; set; } = null!;
        public double? Score { get; set; }
        public DateTime? ExamDate { get; set; }
        public string? ExamId { get; set; }
        public string? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
