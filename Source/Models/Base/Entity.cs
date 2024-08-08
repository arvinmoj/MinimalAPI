namespace Models.Base;
public abstract class Entity : Interfaces.IEntity
{
    public int Id { get; set; }
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}