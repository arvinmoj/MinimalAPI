namespace Models.Interfaces;
public interface IEntity
{
    Guid Id { get; set; }

    DateTime CreatedOn { get; set; }
}