namespace X_Trading.API.Contrects;

public sealed record CreateUserRequest(
    string firstName,
    string lastName,
    string email, 
    string password);
