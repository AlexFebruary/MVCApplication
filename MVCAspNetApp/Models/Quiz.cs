using System.ComponentModel.DataAnnotations;

namespace MVCAspNetApp.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }
    }
}