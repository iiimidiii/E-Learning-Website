using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eleaning_Web.Model
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Period { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public ICollection<Class> classes { get; set; }
    }
}
