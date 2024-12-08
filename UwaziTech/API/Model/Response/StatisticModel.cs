namespace UwaziTech.API.Model.Response
{
    public class StatisticModel
    {
        public int InvoicesUploadedNumber { get; set; }
        public int FraudReports { get; set; }
        public int FlaggedConfirmations { get; set; }
        public int NumberOfInsurance { get; set; }
        public int NumberOfHospital { get; set; }
    }
}
