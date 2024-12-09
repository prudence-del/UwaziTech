namespace UwaziTech.Core.Models.request
{
    public class HospitalDetails
    {
        public string? Reference { get; set; } = Guid.NewGuid().ToString("N");
        public string? HospitalName { get; set; }
        public string? Address { get; set; }
        public string? Branch { get; set; }
    }
}
