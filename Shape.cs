namespace Shape;
/// <summary>
/// Shape abstract class
/// </summary>
public abstract class Shape {
    private readonly int id;
    private readonly String name;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">id of shape</param>
    /// <param name="name">name of shape</param>
    public Shape(int id, String name) {
        this.id = id;
        this.name = name;
    }

    /// <summary>
    /// Get method to retrieve id of shape
    /// </summary>
    /// <returns>Shape id</returns>
    public int GetId() {
        return this.id;
    }

    /// <summary>
    /// Get method to retrieve name of shape
    /// </summary>
    /// <returns>Shape name</returns>
    public String GetName() {
        return this.name;
    }

    /// <summary>
    /// Abstract method to calculate area of shape
    /// </summary>
    /// <returns>Area of shape</returns>
    public abstract double CalculateArea();

    /// <summary>
    /// Abstract method to calculate perimeter of shape
    /// </summary>
    /// <returns>Perimeter of shape</returns>
    public abstract double CalculatePerimeter();
}
