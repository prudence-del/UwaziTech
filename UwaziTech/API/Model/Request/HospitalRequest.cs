using System.Diagnostics.CodeAnalysis;
using UwaziTech.Core.Models.request;

namespace UwaziTech.API.Model.Request
{
    public class HospitalRequest
    {
        public string? HospitalName { get; set; }
        public string? Address { get; set; }
        public string? Branch { get; set; }

        public static implicit operator HospitalDetails([NotNull] HospitalRequest request)
        {
            return new HospitalDetails
            {
                HospitalName = request.HospitalName,
                Address = request.Address,
                Branch = request.Branch,
            };
        }
    }
}
