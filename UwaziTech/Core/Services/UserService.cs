using UwaziTech.Core.Models;
using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;
using UwaziTech.Infrastructure.Context;

namespace UwaziTech.Core.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _appDbContext;

    public UserService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<ApiResponse<UserDetails>> AddUserAsync(UserDetails request, CancellationToken token)
    {
        _appDbContext.UserDetail.Add(request);
        var result = await _appDbContext.SaveChangesAsync(token) > 0;

        if (result) 
        {
            return new ApiResponse<UserDetails>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.DB_ADD_SUCCESSFUL,
                ResponseObject = request,
            };
        }
        else
        {
            return new ApiResponse<UserDetails>
            {
                StatusCode = ResponseCode.FAILED,
                StatusMessage = StatusMessage.DB_ADD_UNSUCCESSFUL,
            };
        }        
    }

    public async Task<ApiResponse> PreRequestAsync(CancellationToken token)
    {
        return new ApiResponse
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
        };
    }

    public async Task<ApiResponse<UserDetails>> UpdateUserDetailsAsync(UserDetails request, CancellationToken token)
    {
        _appDbContext.UserDetail.Update(request);
        var result = await _appDbContext.SaveChangesAsync(token) > 0;

        if (result) 
        {
            return new ApiResponse<UserDetails>
            {
                StatusCode = ResponseCode.OK,
                StatusMessage = StatusMessage.DB_ADD_SUCCESSFUL,
                ResponseObject = request,
            };
        }
        else
        {
            return new ApiResponse<UserDetails>
            {
                StatusCode = ResponseCode.FAILED,
                StatusMessage = StatusMessage.DB_ADD_UNSUCCESSFUL,
            };
        }
    }
}
