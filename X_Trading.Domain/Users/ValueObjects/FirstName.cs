namespace X_Trading.Domain.Users.ValueObjects;

public sealed class FirstName
{
    public FirstName(string value)
    {
        Value = value;
    }

    public FirstName() 
    {
    }

    public string Value { get; } = default!;
}
