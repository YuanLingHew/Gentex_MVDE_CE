namespace Shape;
using System;

/// <summary>
/// Circle class
/// </summary>
public class Circle : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double radius;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Shape Id</param>
    /// <param name="name">Shape name</param>
    /// <param name="centerX">X-value of the center of circle</param>
    /// <param name="centerY">Y-value of the center of circle</param>
    /// <param name="radius">Radius of circle</param>
    public Circle(int id, String name, double centerX, double centerY, double radius) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.radius = radius;
    }

    /// <summary>
    /// Get method to retrieve centerX
    /// </summary>
    /// <returns>X-value of the center of circle</returns>
    public double GetCenterX() {
        return this.centerX;
    }

    /// <summary>
    /// Get method to retrieve centerY
    /// </summary>
    /// <returns>Y-value of the center of circle</returns>
    public double GetCenterY() {
        return this.centerY;
    }

    /// <summary>
    /// Get method to retrieve radius of circle
    /// </summary>
    /// <returns>Radius of circle</returns>
    public double GetRadius() {
        return this.radius;
    }

    /// <summary>
    /// Method to calculate area of circle
    /// </summary>
    /// <returns>Area of circle</returns>
    public override double CalculateArea() {
        return System.Math.PI * System.Math.Pow(radius, 2);
    }

    /// <summary>
    /// Method to calculate perimeter of circle
    /// </summary>
    /// <returns>Perimeter of circle</returns>
    public override double CalculatePerimeter() {
        return 2 * System.Math.PI * this.GetRadius();
    }
}

/// <summary>
/// Ellipse class
/// </summary>
public class Ellipse : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double r1;
    private readonly double r2;
    private readonly double orientation;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Shape Id</param>
    /// <param name="name">Shape name</param>
    /// <param name="centerX">X-value of the center of ellipse</param>
    /// <param name="centerY">Y-value of the center of ellipse</param>
    /// <param name="r1">Semi-major axis</param>
    /// <param name="r2">Semi-minor axis</param>
    /// <param name="orientation">Orientation in radian</param>
    public Ellipse(int id, String name, double centerX, double centerY, double r1, double r2, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.r1 = r1;
        this.r2 = r2;
        this.orientation = orientation;
    }

    /// <summary>
    /// Get method to retrieve centerX
    /// </summary>
    /// <returns>X-value of the center of ellipse</returns>
    public double GetCenterX() {
        return this.centerX;
    }

    /// <summary>
    /// Get method to retrieve centerY
    /// </summary>
    /// <returns>Y-value of the center of ellipse</returns>
    public double GetCenterY() {
        return this.centerY;
    }

    /// <summary>
    /// Get method to retrieve r1
    /// </summary>
    /// <returns>Semi-major axis</returns>
    public double GetR1() {
        return this.r1;
    }

    /// <summary>
    /// Get method to retrieve r2
    /// </summary>
    /// <returns>Semi-minor axis</returns>
    public double GetR2() {
        return this.r2;
    }

    /// <summary>
    /// Get method to retrieve orientation
    /// </summary>
    /// <returns>Orientation in radian</returns>
    public double GetOrientation() {
        return this.orientation;
    }

    /// <summary>
    /// Method to calculate area of ellipse
    /// </summary>
    /// <returns>Area of ellipse</returns>
    public override double CalculateArea() {
        return System.Math.PI * this.GetR1() * this.GetR2();
    }

    /// <summary>
    /// Method to calculate perimeter of ellipse
    /// </summary>
    /// <returns>Perimeter of ellipse</returns>
    public override double CalculatePerimeter() {
        double x = System.Math.Pow(this.GetR1(), 2) + System.Math.Pow(this.GetR2(), 2);
        return 2 * System.Math.PI * System.Math.Sqrt(x / 2);
    }
}

/// <summary>
/// Equilateral Triangle class
/// </summary>
public class EqTriangle : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double sideLength;
    private readonly double orientation;

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="id">Shape Id</param>
    /// <param name="name">Shape name</param>
    /// <param name="centerX">X-value of the center of EqTriangle</param>
    /// <param name="centerY">Y-value of the center of EqTriangle</param>
    /// <param name="sideLength">Length of each side of EqTriangle</param>
    /// <param name="orientation">Orientation in radian</param>
    public EqTriangle(int id, String name, double centerX, double centerY, double sideLength, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.sideLength = sideLength;
        this.orientation = orientation;
    }

    /// <summary>
    /// Get method to retrieve centerX
    /// </summary>
    /// <returns>X-value of center of EqTriangle</returns>
    public double GetCenterX() {
        return this.centerX;
    }

    /// <summary>
    /// Get method to retrieve centerY
    /// </summary>
    /// <returns>Y-value of center of EqTriangle</returns>
    public double GetCenterY() {
        return this.centerY;
    }

    /// <summary>
    /// Get method to retrieve sideLength
    /// </summary>
    /// <returns>Side length of EqTriangle</returns>
    public double GetSideLength() {
        return this.sideLength;
    }

    /// <summary>
    /// Get method to retrieve orientation
    /// </summary>
    /// <returns>Orientation in radian</returns>
    public double GetOrientation() {
        return this.orientation;
    }

    /// <summary>
    /// Method to calculate area of equilateral triangle
    /// </summary>
    /// <returns>Area of equilateral triangle</returns>
    public override double CalculateArea() {
        return (System.Math.Sqrt(3) / 4) * (System.Math.Pow(this.GetSideLength(), 2));
    }

    /// <summary>
    /// Method to calculate perimeter of equilateral triangle
    /// </summary>
    /// <returns>Perimeter of equilateral triangle</returns>
    public override double CalculatePerimeter() {
        return 3 * this.GetSideLength();
    }
}

/// <summary>
/// Polygon class
/// </summary>
public class Polygon : Shape {
    private readonly double[,] points;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">Shape Id</param>
    /// <param name="name">Shape name</param>
    /// <param name="points">2D array of points in the polygon</param>
    public Polygon(int id, String name, double[,] points) : base(id, name) {
        this.points = points;
    }

    /// <summary>
    /// Get method to retrieve points
    /// </summary>
    /// <returns>2D array of points</returns>
    public double[,] GetPoints() {
        return this.points;
    }

    /// <summary>
    /// Method to calculate area of polygon
    /// </summary>
    /// <returns>Area of polygon</returns>
    public override double CalculateArea() {
        double res = 0;
        for (int i = 0; i < this.GetPoints().GetLength(0) - 1; i++) {
            res += (this.GetPoints()[i, 0] * this.GetPoints()[i + 1, 1]) - (this.GetPoints()[i + 1, 0] * this.GetPoints()[i, 1]);
        }
        return res / 2;
    }

    /// <summary>
    /// Method to calculate perimeter of polygon
    /// </summary>
    /// <returns>Perimeter of polygon</returns>
    public override double CalculatePerimeter() {
        double res = 0;

        for (int i = 0; i < this.GetPoints().GetLength(0) - 1; i++) {
            res += System.Math.Sqrt(System.Math.Pow(this.GetPoints()[i + 1, 0] - this.GetPoints()[i, 0], 2) + System.Math.Pow(this.GetPoints()[i + 1, 1] - this.GetPoints()[i, 1], 2));
        }
        return res;
    }
}

/// <summary>
/// Square class
/// </summary>
public class Square : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double sideLength;
    private readonly double orientation;

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="id">Shape Id</param>
    /// <param name="name">Shape name</param>
    /// <param name="centerX">X-value of the center of Square</param>
    /// <param name="centerY">Y-value of the center of Square</param>
    /// <param name="sideLength">Length of each side of Square</param>
    /// <param name="orientation">Orientation in radian</param>
    public Square(int id, String name, double centerX, double centerY, double sideLength, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.sideLength = sideLength;
        this.orientation = orientation;
    }

    /// <summary>
    /// Get method to retrieve centerX
    /// </summary>
    /// <returns>X-value of center of Square</returns>
    public double GetCenterX() {
        return this.centerX;
    }

    /// <summary>
    /// Get method to retrieve centerY
    /// </summary>
    /// <returns>Y-value of center of Square</returns>
    public double GetCenterY() {
        return this.centerY;
    }

    /// <summary>
    /// Get method to retrieve sideLength
    /// </summary>
    /// <returns>Side length of Square</returns>
    public double GetSideLength() {
        return this.sideLength;
    }

    /// <summary>
    /// Get method to retrieve orientation
    /// </summary>
    /// <returns>Orientation in radian</returns>
    public double GetOrientation() {
        return this.orientation;
    }

    /// <summary>
    /// Method to calculate area of Square
    /// </summary>
    /// <returns>Area of Square</returns>
    public override double CalculateArea() {
        return this.GetSideLength() * this.GetSideLength();
    }

    /// <summary>
    /// Method to calculate perimeter of Square
    /// </summary>
    /// <returns>Perimeter of Square</returns>
    public override double CalculatePerimeter() {
        return 4 * this.GetSideLength();
    }
}