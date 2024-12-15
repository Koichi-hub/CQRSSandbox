using CQRSSandbox.Features.UserFeature.Models;
using MediatR;

namespace CQRSSandbox.Features.UserFeature.Queries
{
    public class GetUserQuery : IRequest<User?>
    {
        public Guid UserUid { get; set; }
    }
}
