using MediatR;

namespace Application.Features.Commands.AppUserCommands;

public class CreateUserCommand : IRequest
{
    public string Username { get; set; }
    public string NameSurname { get; set; }     
    public string Password { get; set; }
    public string Email { get; set; }
    public int? DepartmanId { get; set; }
}

