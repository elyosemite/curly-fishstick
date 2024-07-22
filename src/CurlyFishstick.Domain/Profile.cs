using FluentValidation.Results;

namespace CurlyFishstick.Domain;

public class Profile
{
    public Guid Identifier { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public Profile(string firstName, string lastName)
    {
        Identifier = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
    }

    public ValidationResult Validate()
    {
        ProfileValidator validator = new ProfileValidator();

        return validator.Validate(this);
    }
}
