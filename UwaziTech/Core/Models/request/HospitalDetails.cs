using UwaziTech.API.Model.Response;

namespace UwaziTech.Core.Models.request
{
    public class HospitalDetails
    {
        public string? Branch { get; set; }
        public string? Address { get; set; }
        public string? HospitalName { get; set; }
        public string? Reference { get; set; } = Guid.NewGuid().ToString("N");
        public static implicit operator HospitalModel(HospitalDetails hospitalDetails)
        {
            return new()
            {
                Branch = hospitalDetails.Branch,
                Address = hospitalDetails.Address,
                HospitalName = hospitalDetails.HospitalName,
            };
        }
    }
}
