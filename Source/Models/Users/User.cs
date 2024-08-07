using Models.Items;
using System.ComponentModel.DataAnnotations;

namespace Models.Users;
public class User : Base.Entity
{
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public ICollection<TodoItem>? Todos { get; set; }
    public string? Salt { get; set; }
    public int RateLimitWindowInMinutes { get; set; } = 5;
    public int PermitLimit {get; set; } = 60;
}