using CQRSSandbox.Features.UserFeature.Models;
using MediatR;

namespace CQRSSandbox.Features.UserFeature.Commands
{
    public class RegisterCommand : IRequest<User>
    {
        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
