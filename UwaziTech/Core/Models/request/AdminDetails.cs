using UwaziTech.Core.Models.response;

namespace UwaziTech.Core.Models.request
{
    public class AdminDetails
    {
        public string? Role { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public string? InsuranceName { get; set; }
        public string Reference { get; set; } = Guid.NewGuid().ToString("N");

        public static implicit operator AdminModel(AdminDetails model)
        {
            return new () 
            {
                Role = model.Role,
                Username = model.Username,
                Password = model.Password,
                Reference = model.Reference,
                InsuranceName = model.InsuranceName,
            };

        }
    }
}
