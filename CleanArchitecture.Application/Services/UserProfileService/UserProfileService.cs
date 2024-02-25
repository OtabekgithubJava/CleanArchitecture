using CleanArchitecture.Domain.Entities.DTOs;
using CleanArchitecture.Domain.Entities.Models;

namespace CleanArchitecture.Application.Services.UserProfileService;

public class UserProfileService: IUserProfileService
{
    
    public async Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO userDTO)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserProfile>> GetAllUserProfileAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserProfile>> GetByIdUserProfileAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteUserProfileAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserProfile>> UpdateUserProfileAsync(int id, UserProfileDTO modelDTO)
    {
        throw new NotImplementedException();
    }
}