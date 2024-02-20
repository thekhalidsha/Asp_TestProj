using System.ComponentModel.DataAnnotations;

namespace ToDoAppLatest.Models
{
    public class Login
    {
        [Key]
        public int Login_Id { get; set; }
        [Required]
        public string User_Id { get; set; } 
        [Required]
        public DateTime? Login_Time { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
