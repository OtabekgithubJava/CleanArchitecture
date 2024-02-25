using CleanArchitecture.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Abstractions;

public interface IApplicationDbContext
{
    public DbSet<UserProfile> User { get; set; }
    public Task<int> SaveChangedAsync { get; set; }
}