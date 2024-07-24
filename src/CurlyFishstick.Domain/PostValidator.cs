using FluentValidation;

namespace CurlyFishstick.Domain;

public class PostValidator : AbstractValidator<Post>
{
    public PostValidator()
    {
        RuleFor(post => post.Author).NotNull();
        RuleFor(post => post.Author).NotEmpty();
        
        RuleFor(post => post.Text).NotNull();
        RuleFor(post => post.Text).NotEmpty();
        RuleFor(post => post.Text).MaximumLength(300);
        
        RuleFor(post => post.NumberOfComments).NotNull();
        RuleFor(post => post.NumberOfComments).NotEmpty();
        RuleFor(post => post.NumberOfComments).GreaterThanOrEqualTo(0);
        
        RuleFor(post => post.NumberOfReactions).NotNull();
        RuleFor(post => post.NumberOfReactions).NotEmpty();
        RuleFor(post => post.NumberOfReactions).GreaterThanOrEqualTo(0);
    }
}