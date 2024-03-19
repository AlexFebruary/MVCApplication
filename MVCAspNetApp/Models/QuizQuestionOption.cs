using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAspNetApp.Models
{
    public class QuizQuestionOption
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("QuizQuestion")]
        public int QuizQuestion_Id { get; set; }

        public string text { get; set; }

        public bool is_correct { get; set; }

        public virtual QuizQuestion QuizQuestion { get; set; }
    }
}