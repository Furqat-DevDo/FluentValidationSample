using FluentValidationExample.Data;
using FluentValidationExample.Entities;
using FluentValidationExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsersController : Controller
{
    private readonly AppDb _db;
    public UsersController(AppDb db)
    {
        _db = db;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateUserAsync(UserModel model)
    {
        var user = new User
        {
            Id = model.Id,
            Name = model.Name,
            Eamil = model.Eamil,
            Adrresses = model.Adrresses
            .Select(a => new  Adrress
            {
                Location = a.Location,
                Name = a.Name,
                RegionName = a.RegionName
            })
            .ToList()
        };
        
        
        
        _db.Users.Add(user);
        await _db.SaveChangesAsync();
        
        return Ok(user);
    }
    
}