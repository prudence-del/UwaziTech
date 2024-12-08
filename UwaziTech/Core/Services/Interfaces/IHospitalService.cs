using UwaziTech.API.Model.Response;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Core.Services.Interfaces;

public interface IHospitalService
{
    Task AddHospitalDetailsAsync(HospitalDetails request, CancellationToken token);
    Task<HospitalModel> FetchHospitalDetailsAsync(int id, CancellationToken token);
    Task AddHospitalAdminAsync(HospitalAdminDetails request, CancellationToken token);
}
