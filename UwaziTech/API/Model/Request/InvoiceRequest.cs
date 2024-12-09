using UwaziTech.Core.Models.request;
using System.Diagnostics.CodeAnalysis;

namespace UwaziTech.API.Model.Request
{
    public class InvoiceRequest
    {
        public string? PatientName { get; set; }
        public string? PolicyNumber { get; set; }

        public static implicit operator InvoiceDetails([NotNull] InvoiceRequest request)
        {
            return new InvoiceDetails
            {
                PatientName = request.PatientName,
                PolicyNumber = request.PolicyNumber,
            };
        }
    }
}
