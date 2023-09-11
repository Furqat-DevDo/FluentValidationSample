using System.ComponentModel.DataAnnotations;

namespace FluentValidationExample.Models;

public class AdrressModel
{
    public string? Name { get; set; }
    public string? RegionName { get; set; }
    public string? Location { get; set; }
    public int  UserId { get; set; }
}