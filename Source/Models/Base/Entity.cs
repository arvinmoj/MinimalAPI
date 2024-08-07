namespace Models.Base;
public abstract class Entity : Interfaces.IEntity
{
    protected Entity() : base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}