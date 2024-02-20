using System.ComponentModel.DataAnnotations;

namespace ToDoAppLatest.Models
{
    public class ToDoType
    {
        [Key]
        public int ToDoTypeId { get; set; }
        public string Name { get; set; }
    }
}
