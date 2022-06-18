using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eleaning_Web.Model
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ClassId { get; set; }
        public string NameClass { get; set; }
        public string Link { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
        public List<User> users { get; set; }
    }
}
