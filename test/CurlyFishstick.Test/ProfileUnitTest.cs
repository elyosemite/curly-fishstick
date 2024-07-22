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
        var yuriProfile = new Profile("Yuri", "Melo");

        // Assert
        Assert.IsNotNull(yuriProfile);
    }

    [Test]
    public void ProfileInstanceWithEmptyLastname()
    {
        // Arrange
        var yuriProfile = new Profile("Yuri", string.Empty);

        // Act
        var validation = yuriProfile.Validate();
        
        // Assert
        Assert.IsNotNull(yuriProfile);
        Assert.That(validation, Is.Not.Null);
    }
}