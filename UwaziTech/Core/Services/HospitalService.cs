using UwaziTech.API.Model.Response;
using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;

namespace UwaziTech.Core.Services;

public class HospitalService : IHospitalService
{
    public Task AddHospitalAdminAsync(HospitalAdminDetails request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task AddHospitalDetailsAsync(HospitalDetails request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<HospitalModel> FetchHospitalDetailsAsync(int id, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
