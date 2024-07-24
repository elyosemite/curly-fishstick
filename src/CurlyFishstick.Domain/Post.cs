using ValidationResult = FluentValidation.Results.ValidationResult;

namespace CurlyFishstick.Domain;

public class Post
{
    public string Author { get; set; }
    public string Text { get; set; }
    public int NumberOfReactions { get; set; }
    public int NumberOfComments { get; set; }

    public Post(string author, string text, int numberOfReactions, int numberOfComments)
    {
        Author = author;
        Text = text;
        NumberOfReactions = numberOfReactions;
        NumberOfComments = numberOfComments;
    }

    public ValidationResult Validate()
    {
        PostValidator validator = new PostValidator();

        return validator.Validate(this);
    }
    
    
}