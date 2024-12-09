using UwaziTech.Core.Models;
using UwaziTech.API.Model.Response;
using Microsoft.EntityFrameworkCore;
using UwaziTech.Core.Models.request;
using UwaziTech.Infrastructure.Context;
using UwaziTech.Core.Services.Interfaces;

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

        if (result)
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
                StatusMessage = StatusMessage.DB_ADD_UNSUCCESSFUL,
                ResponseObject = request,
            };
        }
    }

    public async Task<ApiResponse<HospitalDetails>> AddHospitalDetailsAsync(HospitalDetails request, CancellationToken token)
    {
        _appDbContext.HospitalDetail.Add(request);

        var result = await _appDbContext.SaveChangesAsync(token) > 0;

        if (result)
        {
            return new ApiResponse<HospitalDetails>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.DB_ADD_SUCCESSFUL,
                ResponseObject = request,
            };        
        }
        else
        {
            return new ApiResponse<HospitalDetails>
            {
                StatusCode = ResponseCode.FAILED,
                StatusMessage = StatusMessage.DB_ADD_UNSUCCESSFUL,
                ResponseObject = request,
            };
        }
    }

    public async Task<ApiResponse<HospitalModel>> FetchHospitalDetailsAsync(string reference, CancellationToken token)
    {
        var result = await _appDbContext.HospitalDetail.Where(e => e.Reference == reference).FirstOrDefaultAsync();
        
        if (result != null)
        {
            return new ApiResponse<HospitalModel>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.RECORD_FOUND,
                ResponseObject = result
            };
        }
        else
        {
            return new ApiResponse<HospitalModel>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.RECORD_MISSING,
            };
        }        
    }
}
