namespace UwaziTech.Core.Models.request
{
    public class HospitalAdminDetails
    {
        public string? Reference { get; set; } = Guid.NewGuid().ToString("N");
        public string? Username { get; set; }
        public string? Hospital { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
