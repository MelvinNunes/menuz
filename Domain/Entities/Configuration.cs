namespace Domain.Entities;

public class Configuration : Entity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Value { get; set; }
}