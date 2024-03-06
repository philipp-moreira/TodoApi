namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj?.Equals(null) ?? false)
        {
            return false;
        }

        var objConverted = (TodoItem)obj;

        return this.Name.Equals(objConverted.Name, StringComparison.InvariantCultureIgnoreCase) && this.Id.Equals(objConverted.Id);
    }
}