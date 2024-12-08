namespace UwaziTech.API.Model.Response
{
    public class FetchHospitalDetailsModel
    {
        public IEnumerable<HospitalModel>? HospitalModels { get; set; }
        public IEnumerable<HospitalAdminModel>? HospitalAdmins { get; set; }
    }
}
