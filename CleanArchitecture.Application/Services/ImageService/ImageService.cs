using CleanArchitecture.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Application.Services.ImageService;

public class ImageService: IImageService
{
    public async Task<image> CreateImage()
    {
        throw new NotImplementedException();
    }

    public async Task<image> CreateImage(IFormFile missing_name)
    {
        throw new NotImplementedException();
    }
}