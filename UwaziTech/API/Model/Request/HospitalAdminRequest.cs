using UwaziTech.Core.Models.request;
using System.Diagnostics.CodeAnalysis;

namespace UwaziTech.API.Model.Request
{
    public class HospitalAdminRequest
    {
        public string? Role { get; set; }
        public string? Username { get; set; }
        public string? Hospital { get; set; }
        public string? Password { get; set; }

        public static implicit operator HospitalAdminDetails([NotNull] HospitalAdminRequest request)
        {
            return new HospitalAdminDetails
            {
                Role = request.Role,
                Username = request.Username,
                Hospital = request.Hospital,
                Password = request.Password
            };
        }
    }
}
