using UwaziTech.Core.Models;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Core.Services.Interfaces;

public interface IUserService
{
    Task<ApiResponse> PreRequestAsync(CancellationToken token);
    Task<ApiResponse<UserDetails>> AddUserAsync(UserDetails request, CancellationToken token);
    Task<ApiResponse<UserDetails>> UpdateUserDetailsAsync(UserDetails request, CancellationToken token);
}
