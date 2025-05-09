namespace Domain.Entities;

public abstract class Entity
{
    public int Id { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}