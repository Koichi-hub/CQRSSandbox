using CQRSSandbox.Features.UserFeature.Commands;
using CQRSSandbox.Features.UserFeature.Models;
using CQRSSandbox.Features.UserFeature.Repositories;
using MediatR;

namespace CQRSSandbox.Features.UserFeature.Handlers
{
    public class RegisterCommandHandler(UserRepository userRepository) : IRequestHandler<RegisterCommand, User>
    {
        public Task<User> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(userRepository.CreateUser(new User
            {
                Login = request.Login,
                Password = request.Password,
                Name = request.Name,
            }));
        }
    }
}
