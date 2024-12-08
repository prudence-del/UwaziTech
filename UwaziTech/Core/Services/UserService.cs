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
            StatusMessage = string.Empty,
            ResponseObject = request,
        };
    }

    public async Task<ApiResponse> PreRequestAsync(CancellationToken token)
    {
        return new ApiResponse
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = string.Empty,
        };
    }

    public async Task<ApiResponse<UserDetails>> UpdateUserDetailsAsync(UserDetails request, CancellationToken token)
    {
        return new ApiResponse<UserDetails>
        {
            StatusCode = ResponseCode.OK,
            StatusMessage = string.Empty,
            ResponseObject = request,
        };
    }
}
