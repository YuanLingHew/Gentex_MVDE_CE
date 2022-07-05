using Xunit;
using System;
namespace Shape;

public class UnitTest {

    public static IEnumerable<object[]> GetCircle =>
       new List<object[]> {
            new object[] { 254.134, 439.289, 82.3711, 21315.70023, 517.55289 },
            new object[] { 302.63, 181.149, 26.2461, 2164.11049, 164.90911 },
            new object[] { 291.881, 206.893, 2.79884, 24.60968, 17.58563 },
       };

    public static IEnumerable<object[]> GetEllipse =>
       new List<object[]> {
            new object[] { 210.564, 371.34, 25.8827, 46.3943, 1.0234, 3772.45508, 231.6602 },
            new object[] { 431.636, 431.574, 8.41705, 42.8063, 3.4954, 1131.92453, 179.63717 },
            new object[] { 348.93, 144.578, 4.05202, 17.2227, 5.3458, 219.24146, 73.41117 },
       };

    public static IEnumerable<object[]> GetEqTri =>
    new List<object[]> {
            new object[] { 346.746, 51.165, 413.75, 1.3845, 74127.038487521, 1241.25 },
            new object[] { 123.4567, 234.234, 32.34565, 4.2212, 453.0356742498, 97.03695 },
            new object[] { 129.348, 276.438, 432.423, 2.40894, 80968.893974649, 1297.269 },
    };

    public static IEnumerable<object[]> GetPoly =>
    new List<object[]> {
            new object[] { new double[5, 2] { {346.746, 51.165}, {413.75, 208.36}, {309.926, 280.286}, {34.4096, 297.813}, {346.746, 51.165} }, 41810.5961642, 971.2385999634557 },
            new object[] { new double[4, 2] { {381.113, 13.3588}, {245.449, 302.492}, {150.669, 334.177}, {381.113, 13.3588} }, 11552.765428000013, 814.3193298532194 },
            new object[] { new double[5, 2] { {186.527, 6.24889}, {440.576, 135.026}, {447.194, 358.619}, {391.869, 464.493}, {186.527, 6.24889} }, 51522.032718385, 1130.1205999755448 },
    };

    public static IEnumerable<object[]> GetSquare =>
    new List<object[]> {
            new object[] { 346.746, 51.165, 413.75, 1.3845, 171189.0625, 1655 },
            new object[] { 123.4567, 234.234, 32.34565, 4.2212, 1046.2410739225, 129.3826 },
            new object[] { 129.348, 276.438, 432.423, 2.40894, 186989.650929, 1729.692 },
    };

    [Theory]
    [MemberData(nameof(GetCircle))]
    public void TestCircleArea(double centerX, double centerY, double radius, double expectedArea, double expectedPeri) {

        Circle c = new Circle(1, "Circle", centerX, centerY, radius);
        Assert.Equal(System.Math.Round(expectedArea, 3), System.Math.Round(c.CalculateArea(), 3));
    }

    [Theory]
    [MemberData(nameof(GetCircle))]
    public void TestCirclePer(double centerX, double centerY, double radius, double expectedArea, double expectedPeri) {

        Circle c = new Circle(1, "Circle", centerX, centerY, radius);
        Assert.Equal(System.Math.Round(expectedPeri, 3), System.Math.Round(c.CalculatePerimeter(), 3));
    }

    [Theory]
    [MemberData(nameof(GetEllipse))]
    public void TestEllArea(double centerX, double centerY, double r1, double r2, double orientation, double expectedArea, double expectedPeri) {

        Ellipse e = new Ellipse(1, "Ellipse", centerX, centerY, r1, r2, orientation);
        Assert.Equal(System.Math.Round(expectedArea, 3), System.Math.Round(e.CalculateArea(), 3));
    }

    [Theory]
    [MemberData(nameof(GetEllipse))]
    public void TestEllPeri(double centerX, double centerY, double r1, double r2, double orientation, double expectedArea, double expectedPeri) {

        Ellipse e = new Ellipse(1, "Ellipse", centerX, centerY, r1, r2, orientation);
        Assert.Equal(System.Math.Round(expectedPeri, 3), System.Math.Round(e.CalculatePerimeter(), 3));
    }

    [Theory]
    [MemberData(nameof(GetEqTri))]
    public void TestEqTriArea(double centerX, double centerY, double sl, double orientation, double expectedArea, double expectedPeri) {

        EqTriangle e = new EqTriangle(1, "EqTriangle", centerX, centerY, sl, orientation);
        Assert.Equal(System.Math.Round(expectedArea, 3), System.Math.Round(e.CalculateArea(), 3));
    }

    [Theory]
    [MemberData(nameof(GetEqTri))]
    public void TestEqTriPeri(double centerX, double centerY, double sl, double orientation, double expectedArea, double expectedPeri) {

        EqTriangle e = new EqTriangle(1, "EqTriangle", centerX, centerY, sl, orientation);
        Assert.Equal(System.Math.Round(expectedPeri, 3), System.Math.Round(e.CalculatePerimeter(), 3));
    }

    [Theory]
    [MemberData(nameof(GetPoly))]
    public void TestPolyArea(double[,] points, double expectedArea, double expectedPeri) {

        Polygon p = new Polygon(1, "Polygon", points);
        Assert.Equal(System.Math.Round(expectedArea, 3), System.Math.Round(p.CalculateArea(), 3));
    }

    [Theory]
    [MemberData(nameof(GetPoly))]
    public void TestPolyPeri(double[,] points, double expectedArea, double expectedPeri) {

        Polygon p = new Polygon(1, "Polygon", points);
        Assert.Equal(System.Math.Round(expectedPeri, 3), System.Math.Round(p.CalculatePerimeter(), 3));
    }

    [Theory]
    [MemberData(nameof(GetSquare))]
    public void TestSquareArea(double centerX, double centerY, double sl, double orientation, double expectedArea, double expectedPeri) {

        Square s = new Square(1, "Square", centerX, centerY, sl, orientation);
        Assert.Equal(System.Math.Round(expectedArea, 3), System.Math.Round(s.CalculateArea(), 3));
    }

    [Theory]
    [MemberData(nameof(GetSquare))]
    public void TestSquarePeri(double centerX, double centerY, double sl, double orientation, double expectedArea, double expectedPeri) {

        Square s = new Square(1, "Square", centerX, centerY, sl, orientation);
        Assert.Equal(System.Math.Round(expectedPeri, 3), System.Math.Round(s.CalculatePerimeter(), 3));
    }
}

