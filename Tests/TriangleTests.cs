using SurfaceCalc;

namespace Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ShouldThrow_ArgumentException_OnNonTriangleInput()
    {
        // Arrange
        double aSide = 1;
        double bSide = 0.5;
        double cSide = 2;
        
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Triangle(aSide, bSide, cSide));
    }

    [Fact]
    public void Sides_ShouldBeActual_OnValidInput()
    {
        // Arrange
        double aSide = 1;
        double bSide = 2.5;
        double cSide = 2;
        
        // Act
        var triangle = new Triangle(aSide, bSide, cSide);
        
        // Assert
        Assert.True(aSide == triangle.FirstSide &&
                    bSide == triangle.SecondSide &&
                    cSide == triangle.ThirdSide);
    }

    [Fact]
    public void Triangle_ShouldBeRight_IfItIsRight()
    {
        // Arrange
        double aSide = 3;
        double bSide = 4;
        double cSide = 5;
        var triangle = new Triangle(aSide, bSide, cSide);
        
        // Act
        var actual = triangle.IsRightTriangle();
        
        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void Triangle_ShouldNotBeRight_IfItIsNotRight()
    {
        // Arrange
        double aSide = 4;
        double bSide = 4;
        double cSide = 5;
        var triangle = new Triangle(aSide, bSide, cSide);
        
        // Act
        var actual = triangle.IsRightTriangle();
        
        // Assert
        Assert.False(actual);
    }

    [Theory]
    [InlineData(3,4,5)]
    public void Surface_ShouldBeEqualTo_Actual(double aSide, double bSide, double cSide)
    {
        // Arrange
        var triangle = new Triangle(aSide, bSide, cSide);
        double p = (aSide + bSide + cSide)/2d;
        double expected =  Math.Sqrt(
            p * (p-aSide) * (p-bSide) * (p-cSide)
        );
        
        // Act
        var actual = triangle.CalculateSurface();
        
        // Assert
        Assert.Equal(expected, actual);
    }
}