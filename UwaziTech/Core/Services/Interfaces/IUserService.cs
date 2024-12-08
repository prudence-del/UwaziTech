using UwaziTech.Core.Models.request;

namespace UwaziTech.Core.Services.Interfaces;

public interface IUserService
{
    Task PreRequestAsync(CancellationToken token);
    Task AddUserAsync(UserDetails request, CancellationToken token);
    Task UpdateUserDetailsAsync(UserDetails request, CancellationToken token);
}
