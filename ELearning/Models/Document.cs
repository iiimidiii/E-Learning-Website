using System;
using System.Collections.Generic;

namespace Eleaning_Web.Models
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string? NameDocument { get; set; }
        public string? Link { get; set; }
        public string? IdSubject { get; set; }
        public string? SubjectId { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
