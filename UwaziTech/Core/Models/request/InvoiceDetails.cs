namespace UwaziTech.Core.Models.request
{
    public class InvoiceDetails
    {
        public string Reference { get; set; } = Guid.NewGuid().ToString("N");
        public string? PolicyNumber { get; set; }
        public string? PatientName { get; set; }
    }
}
