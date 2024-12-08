using UwaziTech.API.Model.Request;
using UwaziTech.API.Model.Response;
using UwaziTech.Core.Models;
using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;

namespace UwaziTech.Core.Services;

public class HospitalService : IHospitalService
{
    public async Task<ApiResponse<HospitalAdminDetails>> AddHospitalAdminAsync(HospitalAdminDetails request, CancellationToken token)
    {
        return new ApiResponse<HospitalAdminDetails>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
            ResponseObject = request,
        };
    }

    public async Task<ApiResponse<HospitalDetails>> AddHospitalDetailsAsync(HospitalDetails request, CancellationToken token)
    {
        return new ApiResponse<HospitalDetails>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
            ResponseObject = request,
        };
    }

    public async Task<ApiResponse<HospitalModel>> FetchHospitalDetailsAsync(string reference, CancellationToken token)
    {
        var response = new HospitalModel
        {
            Address = reference,
            Branch = reference,
            HospitalName = reference,
        };

        return new ApiResponse<HospitalModel>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
            ResponseObject = null,
        };
    }
}
