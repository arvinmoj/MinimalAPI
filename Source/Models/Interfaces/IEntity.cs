namespace Models.Interfaces;
public interface IEntity
{
    int Id { get; set; }

    DateTime CreatedOn { get; set; }
}