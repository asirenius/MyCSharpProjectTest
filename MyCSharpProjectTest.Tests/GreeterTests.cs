using MyCSharpProjectTest.Library;

namespace MyCSharpProjectTest.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsCorrectGreeting()
    {
        // Arrange
        string name = "John";
        string expectedGreeting = "Hello, John!";

        // Act
        string actualGreeting = Greeter.Greet(name);

        // Assert
        Assert.Equal(expectedGreeting, actualGreeting);

    }

    [Fact]
    public void Greet_ReturnsCorrectGreetingEmpty()
    {
        // Arrange
        string name = "";
        string expectedGreeting = "Hello, !";

        // Act
        string actualGreeting = Greeter.Greet(name);

        // Assert
        Assert.Equal(expectedGreeting, actualGreeting);

    }
}
