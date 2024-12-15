namespace CQRSSandbox.Features.UserFeature.Models
{
    public class User
    {
        public Guid Uid { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
