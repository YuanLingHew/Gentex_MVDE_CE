namespace Shape;
using System;
public class Circle : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double radius;

    public Circle(int id, String name, double centerX, double centerY, double radius) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.radius = radius;
    }

    public double GetCenterX() {
        return this.centerX;
    }

    public double GetCenterY() {
        return this.centerY;
    }

    public double GetRadius() {
        return this.radius;
    }

    public override double CalculateArea() {
        return System.Math.PI * System.Math.Pow(radius, 2);
    }

    public override double CalculatePerimeter() {
        return 2 * System.Math.PI * this.GetRadius();
    }
}

public class Ellipse : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double r1;
    private readonly double r2;
    private readonly double orientation;

    public Ellipse(int id, String name, double centerX, double centerY, double r1, double r2, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.r1 = r1;
        this.r2 = r2;
        this.orientation = orientation;
    }

    public double GetCenterX() {
        return this.centerX;
    }

    public double GetCenterY() {
        return this.centerY;
    }

    public double GetR1() {
        return this.r1;
    }

    public double GetR2() {
        return this.r2;
    }

    public double GetOrientation() {
        return this.orientation;
    }

    public override double CalculateArea() {
        return System.Math.PI * this.GetR1() * this.GetR2();
    }

    public override double CalculatePerimeter() {
        return System.Math.PI * (this.GetR1() * this.GetR2());
    }
}

public class EqTriangle : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double sideLength;
    private readonly double orientation;

    public EqTriangle(int id, String name, double centerX, double centerY, double sideLength, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.sideLength = sideLength;
        this.orientation = orientation;
    }

    public double GetCenterX() {
        return this.centerX;
    }

    public double GetCenterY() {
        return this.centerY;
    }

    public double GetSideLength() {
        return this.sideLength;
    }

    public double GetOrientation() {
        return this.orientation;
    }

    public override double CalculateArea() {
        return System.Math.Sqrt(3) / 4 * this.GetSideLength();
    }

    public override double CalculatePerimeter() {
        return 3 * this.GetSideLength();
    }
}

public class Polygon : Shape {
    private readonly double[,] points;

    public Polygon(int id, String name, double[,] points) : base(id, name) {
        this.points = points;
    }

    public double[,] GetPoints() {
        return this.points;
    }

    public override double CalculateArea() {
        double res = 0;
        for (int i = 0; i < this.GetPoints().GetLength(0) - 1; i++) {
            res += (this.GetPoints()[i, 0] * this.GetPoints()[i + 1, 1]) - (this.GetPoints()[i + 1, 0] * this.GetPoints()[i, 1]);
        }
        return res / 2;
    }

    public override double CalculatePerimeter() {
        double res = 0;

        for (int i = 0; i < this.GetPoints().GetLength(0) - 1; i++) {
            res += System.Math.Sqrt(System.Math.Pow(this.GetPoints()[i + 1, 0] - this.GetPoints()[i, 0], 2) + System.Math.Pow(this.GetPoints()[i + 1, 1] - this.GetPoints()[i, 1], 2));
        }
        return res;
    }
}

public class Square : Shape {
    private readonly double centerX;
    private readonly double centerY;
    private readonly double sideLength;
    private readonly double orientation;

    public Square(int id, String name, double centerX, double centerY, double sideLength, double orientation) : base(id, name) {
        this.centerX = centerX;
        this.centerY = centerY;
        this.sideLength = sideLength;
        this.orientation = orientation;
    }

    public double GetCenterX() {
        return this.centerX;
    }

    public double GetCenterY() {
        return this.centerY;
    }

    public double GetSideLength() {
        return this.sideLength;
    }

    public double GetOrientation() {
        return this.orientation;
    }

    public override double CalculateArea() {
        return this.GetSideLength() * this.GetSideLength();
    }

    public override double CalculatePerimeter() {
        return 4 * this.GetSideLength();
    }
}