using CQRSSandbox.Features.UserFeature.Models;
using CQRSSandbox.Features.UserFeature.Queries;
using CQRSSandbox.Features.UserFeature.Repositories;
using MediatR;

namespace CQRSSandbox.Features.UserFeature.Handlers
{
    public class GetUserQueryHandler(UserRepository userRepository) : IRequestHandler<GetUserQuery, User?>
    {
        public Task<User?> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(userRepository.GetUser(request.UserUid));
        }
    }
}
