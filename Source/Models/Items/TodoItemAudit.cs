namespace Models.Items;
public class TodoItemAudit : Base.Entity
{
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
}