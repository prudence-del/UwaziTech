using UwaziTech.Core.Models;
using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;

namespace UwaziTech.Core.Services;

public class UserService : IUserService
{
    public async Task<ApiResponse<UserDetails>> AddUserAsync(UserDetails request, CancellationToken token)
    {
        return new ApiResponse<UserDetails>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
            ResponseObject = request,
        };
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
        return new ApiResponse<UserDetails>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = StatusMessage.PENDING_IMPLEMENTATION,
            ResponseObject = request,
        };
    }
}
