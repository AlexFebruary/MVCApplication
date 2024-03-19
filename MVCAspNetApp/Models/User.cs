using System.ComponentModel.DataAnnotations;

namespace MVCAspNetApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string last_name { get; set; }

        public string first_name { get; set; }

        public string email { get; set; }
    }
}