using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
            Documents = new HashSet<Document>();
            Exams = new HashSet<Exam>();
        }

        public string SubjectId { get; set; } = null!;
        public string? SubjectName { get; set; }
        public string? Period { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
