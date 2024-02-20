using System.ComponentModel.DataAnnotations;

namespace ToDoAppLatest.Models
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
