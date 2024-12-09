namespace UwaziTech.Core.Models.request
{
    public class InvoiceDetails
    {
        public string? PatientName { get; set; }
        public string? PolicyNumber { get; set; }
        public string? Reference { get; set; } = Guid.NewGuid().ToString("N");
    }
}
