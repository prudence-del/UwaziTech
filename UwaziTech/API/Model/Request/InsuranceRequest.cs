using UwaziTech.Core.Models.request;
using System.Diagnostics.CodeAnalysis;

namespace UwaziTech.API.Model.Request
{
    public class InsuranceRequest
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public static implicit operator InsuranceDetails([NotNull] InsuranceRequest request)
        {
            return new InsuranceDetails()
            {
                Name = request.Name,
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
            };
        }
    }
}
