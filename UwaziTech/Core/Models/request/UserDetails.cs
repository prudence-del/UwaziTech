namespace UwaziTech.Core.Models.request
{
    public class UserDetails
    {
        public string? Reference { get; set; } = Guid.NewGuid().ToString("N");
        public string? Username { get; set; }
        public string? BranchName { get; set; }
        public string? Password { get; set; }
    }
}
