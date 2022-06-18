using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string ExamType { get; set; }
        public DateTime ExamDate { get; set; }

        public string ExamCode { get; set; }
        public string Descri { get; set; }

      
        public int IdSubject { get; set; }
        public Subject Subject  { get; set; }

    }
}
