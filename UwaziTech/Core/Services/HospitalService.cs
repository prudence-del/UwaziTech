using UwaziTech.API.Model.Request;
using UwaziTech.API.Model.Response;
using UwaziTech.Core.Models;
using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;
using UwaziTech.Infrastructure.Context;

namespace UwaziTech.Core.Services;

public class HospitalService : IHospitalService
{
    private readonly AppDbContext _appDbContext;
    public HospitalService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<ApiResponse<HospitalAdminDetails>> AddHospitalAdminAsync(HospitalAdminDetails request, CancellationToken token)
    {
        _appDbContext.HospitalAdminDetail.Add(request);
        
        var result = await _appDbContext.SaveChangesAsync(token) > 0;

        if (!result)
        {
            return new ApiResponse<HospitalAdminDetails>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.DB_ADD_SUCCESSFUL,
                ResponseObject = request,
            };
        }
        else
        {
            return new ApiResponse<HospitalAdminDetails>
            {
                StatusCode = ResponseCode.FAILED,
                StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
                ResponseObject = request,
            };
        }
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
