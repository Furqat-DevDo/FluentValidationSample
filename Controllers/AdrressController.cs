using FluentValidation;
using FluentValidationExample.Data;
using FluentValidationExample.Models;
using FluentValidationExample.Validations;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdrressController : Controller
{
    private IValidator<AdrressModel> _validator;
    private readonly AppDb _db;
    public AdrressController(IValidator<AdrressModel> validator,
        AppDb db)
    {
        _validator = validator;
        _db = db;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAdrressAsync(AdrressModel model)
    {
        var result = await _validator.ValidateAsync(model);
        
        if (!result.IsValid || result.Errors.Count > 0)
        {
            result.AddToModelState(this.ModelState);
            return BadRequest(ModelState);
        }
        return Ok();
    }
}