using SurfaceCalc;

namespace Tests;

public class CircleTests
{
    [Theory]
    [InlineData(99d)]
    public void Surface_ShouldBeEqualTo_Actual(double radius)
    {
        // Arrange
        ISurfaceCalculatable circle = new Circle(radius);
        var expected = Math.PI *radius * radius ;

        // Act
        var actual = circle.CalculateSurface();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Radius_ShouldBeZero_OnNegativeInput()
    {
        // Arrange
        Circle circle = new Circle(-6616555);
        var expected = 0d;

        // Act
        var actual = circle.Radius;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Radius_ShouldBeEqualToInput_OnValidInput()
    {
        // Arrange
        Circle circle = new Circle(123123);
        double expected = 123123d;

        // Act
        var actual = circle.Radius;

        // Assert
        Assert.Equal(expected, actual);
    }
}