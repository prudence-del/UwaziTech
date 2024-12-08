using System.Diagnostics.CodeAnalysis;
using UwaziTech.Core.Models.request;

namespace UwaziTech.API.Model.Request
{
    public class HospitalAdminRequest
    {
        public string? Username { get; set; }
        public string? Hospital { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public static implicit operator HospitalAdminDetails([NotNull] HospitalAdminRequest request)
        {
            return new HospitalAdminDetails
            {
                Username = request.Username,
                Hospital = request.Hospital,
                Password = request.Password,
                Role = request.Role
            };
        }
    }
}
