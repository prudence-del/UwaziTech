using UwaziTech.Core.Models.request;
using System.Diagnostics.CodeAnalysis;

namespace UwaziTech.API.Model.Request
{
    public class HospitalRequest
    {
        public string? Branch { get; set; }
        public string? Address { get; set; }
        public string? HospitalName { get; set; }

        public static implicit operator HospitalDetails([NotNull] HospitalRequest request)
        {
            return new HospitalDetails
            {
                Branch = request.Branch,
                Address = request.Address,
                HospitalName = request.HospitalName,
            };
        }
    }
}
