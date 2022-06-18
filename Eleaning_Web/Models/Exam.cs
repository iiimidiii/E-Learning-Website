using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class Exam
    {
        public string ExamId { get; set; } = null!;
        public string? ExamName { get; set; }
        public string? ExamType { get; set; }
        public string? ExamCode { get; set; }
        public string? ExamDate { get; set; }
        public string? Descri { get; set; }
        public string? SubjectId { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
