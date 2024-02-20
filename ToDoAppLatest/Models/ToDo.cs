using System.ComponentModel.DataAnnotations;

namespace ToDoAppLatest.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ToDoType { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public string FromTime { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public string ToTime { get; set; }
    }
}
