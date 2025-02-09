namespace X_Trading.Domain.Users.ValueObjects;

public sealed class Email
{
    public Email(string value)
    {
        Value = value;
    }
    public Email()
    {
    }
    public string Value { get; } = default!;
}   
