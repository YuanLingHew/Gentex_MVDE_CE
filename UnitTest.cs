using Xunit;
using System;
namespace Shape;

public class UnitTest {
    public static IEnumerable<object[]> CircleAreaData =>
        new List<object[]> {
            new object[] { 254.134, 439.289, 82.3711, 21315.70023 },
            new object[] { 302.63, 181.149, 26.2461, 2164.11049 },
            new object[] { 291.881, 206.893, 2.79884, 24.60968 },
        };

    [Theory]
    [MemberData(nameof(CircleAreaData))]
    public void TestCircleArea(double centerX, double centerY, double radius, double expected) {

        Circle c = new Circle(1, "Circle", centerX, centerY, radius);
        Assert.Equal(expected, c.CalculateArea());
    }
}

