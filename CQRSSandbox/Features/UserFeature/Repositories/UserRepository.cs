using CQRSSandbox.Features.UserFeature.Models;
using System.Collections.Concurrent;

namespace CQRSSandbox.Features.UserFeature.Repositories
{
    public class UserRepository
    {
        private readonly ConcurrentDictionary<Guid, User> users = new();

        public User CreateUser(User user)
        {
            user.Uid = Guid.NewGuid();
            users.TryAdd(user.Uid, user);
            return user;
        }

        public User? GetUser(Guid uid)
        {
            if (!users.ContainsKey(uid))
            {
                return null;
            }

            return users[uid];
        }
    }
}
