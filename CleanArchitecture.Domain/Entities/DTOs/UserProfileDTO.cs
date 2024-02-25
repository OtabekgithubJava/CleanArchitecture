using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CleanArchitecture.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Domain.Entities.DTOs;

public class UserProfileDTO
{
    [NotMapped] // Undirects from the database as a column
    public IFormFile? Picture { get; set; }
    public string? FullName { get; set; }
    public string? Phone { get; set; }
    public Role UserRole { get; set; }
    
    // Max/min requirements
    [MinLength(5), MaxLength(30)]
    public required string? Login { get; set; }
    
    // Max/min requirements
    [MinLength(6)]
    public required string? Password { get; set; }
    
    [JsonIgnore] // Doesn't provide its JSON version, but creates a DB column
    public string? PicturePath { get; set; }
}