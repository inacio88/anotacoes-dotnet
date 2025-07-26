namespace simplifyCSharp;

public record EmployeeRecord(int Id, string Name);

public class EmployeeModel
{
    public required int Id { get; init; }
    public required string Name { get; init; }
}