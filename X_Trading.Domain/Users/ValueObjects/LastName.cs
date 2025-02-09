namespace X_Trading.Domain.Users.ValueObjects;

public sealed class LastName
{
    public LastName(string value)
    {
        Value = value;
    }

    public LastName()
    {
    }   

    public string Value { get; } = default!;    
}
