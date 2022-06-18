using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ResultId { get; set; }
        public float Score { get; set; }
        public DateTime Examdate { get; set; }
        public int IdExam { get; set; }
        public Exam exam { get; set; }
        public int IdUser { get; set; }
        public User user { get; set; }
    }
}
