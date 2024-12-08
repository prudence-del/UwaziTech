namespace UwaziTech.API.Model.Response
{
    public class ClaimsModel
    {
        public Invoice? Invoice { get; set; }
        public string? FraudReport { get; set; }
        public string? ConfirmationReport { get; set; }
    }
}
