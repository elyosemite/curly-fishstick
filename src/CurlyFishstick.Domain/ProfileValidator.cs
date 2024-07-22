using FluentValidation;

namespace CurlyFishstick.Domain;

public class ProfileValidator : AbstractValidator<Profile>
{
    public ProfileValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.FirstName).NotNull();
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).NotNull();
    }
}