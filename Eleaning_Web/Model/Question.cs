using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string QuestionId { get; set; }
        public string Form { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
