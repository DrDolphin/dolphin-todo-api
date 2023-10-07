namespace DolphinTodoWebAPI.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int DurationInMinutes { get; set; }
        public int UserId { get; set; }
    }
}