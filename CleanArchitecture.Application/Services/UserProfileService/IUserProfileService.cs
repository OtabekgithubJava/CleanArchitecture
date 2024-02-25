using CleanArchitecture.Domain.Entities.DTOs;
using CleanArchitecture.Domain.Entities.Models;

namespace CleanArchitecture.Application.Services.UserProfileService;

public interface IUserProfileService
{
    public Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO userDTO);
    public Task<List<UserProfile>> GetAllUserProfileAsync();
    public Task<List<UserProfile>> GetByIdUserProfileAsync(int id);
    public Task<bool> DeleteUserProfileAsync(int id);
    public Task<List<UserProfile>> UpdateUserProfileAsync(int id, UserProfileDTO modelDTO);
}