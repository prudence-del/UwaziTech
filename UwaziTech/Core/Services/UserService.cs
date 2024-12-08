using UwaziTech.Core.Models.request;
using UwaziTech.Core.Services.Interfaces;

namespace UwaziTech.Core.Services;

public class UserService : IUserService
{
    public Task AddUserAsync(UserDetails request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task PreRequestAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserDetailsAsync(UserDetails request, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
