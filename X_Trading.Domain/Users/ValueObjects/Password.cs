namespace X_Trading.Domain.Users.ValueObjects;

public sealed class Password
{
    public Password(string value)
    {
        Value = value;
    }
    public Password()
    {
    }
    public string Value { get; } = default!;
}
