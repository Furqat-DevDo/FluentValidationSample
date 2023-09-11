using System.Data;
using FluentValidation;
using FluentValidationExample.Models;

namespace FluentValidationExample.Validations;

public class AdrressValidator : AbstractValidator<AdrressModel>
{
    
    public AdrressValidator()
    {
        //RuleLevelCascadeMode = CascadeMode.Stop;
        
        // RuleFor(a => a.Name).NotEmpty()
        //     .NotNull()
        //     .MaximumLength(30)
        //     .MinimumLength(3);
        
        RuleFor(x => x.RegionName).NotNull().DependentRules(() => 
        {
            RuleFor(x => x.Name).NotNull();
        });
    }
}