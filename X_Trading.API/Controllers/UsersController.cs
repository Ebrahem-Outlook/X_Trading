using MediatR;
using Microsoft.AspNetCore.Mvc;
using X_Trading.API.Contrects;
using X_Trading.Application.Users.Commands.CreateUser;

namespace X_Trading.API.Controllers;

public sealed class UsersController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserRequest request)
    {
        await sender.Send(new CreateUserCommand(request.firstName, request.lastName, request.email, request.password));

        return Ok();
    }
}
