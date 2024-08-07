using Models.Users;
using System.ComponentModel.DataAnnotations;

namespace Models.Items;
public class TodoItem : Base.Entity
{
    [Required]
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
    public User User { get; set; } = null!;
    public int UserId { get; set; }
}