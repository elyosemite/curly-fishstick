using CurlyFishstick.Domain;

namespace CurlyFishstick.Test;

public class ProfileUnitTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ProfileInstanceIsNotNull()
    {
        // Arrange && act
        var userProfile = new Profile("Yuri", "Melo");

        // Assert
        Assert.IsNotNull(userProfile);
    }

    [Test]
    public void ProfileInstanceWithEmptyLastname()
    {
        // Arrange
        var userProfile = new Profile(null, null);

        // Act
        var validation = userProfile.Validate();
        
        // Assert
        Assert.IsNotNull(userProfile);
        Assert.That(validation, Is.Not.Null);
    }
}