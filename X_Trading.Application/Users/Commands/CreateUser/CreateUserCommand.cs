using FluentValidation;
using MediatR;
using X_Trading.Application.Core.Data;
using X_Trading.Application.Core.Masseges;
using X_Trading.Domain.Users;

namespace X_Trading.Application.Users.Commands.CreateUser;

public record CreateUserCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : ICommand;

internal sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }   

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = User.Create(request.FirstName, request.LastName, request.Email, request.Password);

        await _userRepository.AddAsync(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

internal class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotEmpty().MaximumLength(50);

        RuleFor(user => user.LastName).NotEmpty().MaximumLength(50);

        RuleFor(user => user.Email).NotEmpty().MaximumLength(50);

        RuleFor(user => user.Password).NotEmpty().MaximumLength(50);
    }
}
