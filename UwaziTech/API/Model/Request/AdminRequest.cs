using System.Diagnostics.CodeAnalysis;
using UwaziTech.Core.Models.request;

namespace UwaziTech.API.Model.Request
{
    public class AdminRequest
    {
        public string? Username { get; set; }
        public string? Role { get; set; }
        public string? InsuranceName { get; set; }
        public string? Password { get; set; }

        public static implicit operator AdminDetails([NotNull] AdminRequest request)
        {
            return new AdminDetails()
            {
                Role = request.Role,
                Username = request.Username,
                Password = request.Password,
                InsuranceName = request.InsuranceName,
            };
        }
    }
}
