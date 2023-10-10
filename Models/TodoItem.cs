using System.ComponentModel.DataAnnotations;

namespace DolphinTodoWebAPI.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int DurationInMinutes { get; set; }
        [Required]
        public int UserId { get; set; }
        public Boolean Status { get; set; } = false;
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}