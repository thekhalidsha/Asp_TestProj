using System.ComponentModel.DataAnnotations;

namespace ToDoAppLatest.Models.ViewModel
{
    public class Users
    {
        public string User_Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
