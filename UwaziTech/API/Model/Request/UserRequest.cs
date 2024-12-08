using System.Diagnostics.CodeAnalysis;
using UwaziTech.Core.Models.request;

namespace UwaziTech.API.Model.Request
{
    public class UserRequest
    {
        public string? Username { get; set; }
        public string? BranchName { get; set; }
        public string? Password { get; set; }

        public static implicit operator UserDetails([NotNull] UserRequest request)
        {
            return new UserDetails
            {
                Username = request.Username,
                BranchName = request.BranchName,
                Password = request.Password
            };
        }
    }
}
