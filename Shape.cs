namespace Shape;
public abstract class Shape {
    private readonly int id;
    private readonly String name;

    public Shape(int id, String name) {
        this.id = id;
        this.name = name;
    }

    public int GetId() {
        return this.id;
    }

    public String GetName() {
        return this.name;
    }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}
