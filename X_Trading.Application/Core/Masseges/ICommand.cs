using MediatR;

namespace X_Trading.Application.Core.Masseges;

public interface ICommand : IRequest
{
}

public interface ICommand<out TCommand> : IRequest<TCommand>
    where TCommand : class
{
}
