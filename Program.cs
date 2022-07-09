using System;
namespace Shape;
/// <summary>
/// Main class of the program
/// </summary>
public class Program {

    /// <summary>
    /// Reads csv file and imports shapes
    /// </summary>
    /// <returns>List of Shape objects</returns>
    public static List<Shape> ImportShapes() {
        List<Shape> ret = new();
        using (var reader = new StreamReader("Machine Vision Development Engineer Coding Exercise _ ShapeList2.csv")) {
            // reads every line in csv file
            while (!reader.EndOfStream) {
                // reads line and uses ',' as delimiter
                var line = reader.ReadLine();
                var values = line.Split(',');

                // check type of shape and add to list of shapes
                if (string.Equals(values[1], "Circle")) {
                    ret.Add(new Circle(Convert.ToInt32(values[0]), values[1], Convert.ToDouble(values[3]), Convert.ToDouble(values[5]), Convert.ToDouble(values[7])));
                } else if (string.Equals(values[1], "Ellipse")) {
                    ret.Add(new Ellipse(Convert.ToInt32(values[0]), values[1], Convert.ToDouble(values[3]), Convert.ToDouble(values[5]), Convert.ToDouble(values[7]), Convert.ToDouble(values[9]), Convert.ToDouble(values[11])));
                } else if (string.Equals(values[1], "Equilateral Triangle")) {
                    ret.Add(new EqTriangle(Convert.ToInt32(values[0]), values[1], Convert.ToDouble(values[3]), Convert.ToDouble(values[5]), Convert.ToDouble(values[7]), Convert.ToDouble(values[9])));
                } else if (string.Equals(values[1], "Polygon")) {
                    // calculate number of points
                    int num = (values.Length - 2) / 4;
                    double[,] points = new double[num, 2];
                    int index = 0;

                    // populate points array
                    for (int i = 3; i < values.Length; i += 4) {
                        points[index, 0] = Convert.ToDouble(values[i]);
                        points[index, 1] = Convert.ToDouble(values[i + 2]);
                        index++;
                    }
                    ret.Add(new Polygon(Convert.ToInt32(values[0]), values[1], points));
                } else if (string.Equals(values[1], "Square")) {
                    ret.Add(new Square(Convert.ToInt32(values[0]), values[1], Convert.ToDouble(values[3]), Convert.ToDouble(values[5]), Convert.ToDouble(values[7]), Convert.ToDouble(values[9])));
                } else {
                    throw new Exception("Something went wrong.");
                }
            }
        }
        return ret;
    }

    /// <summary>
    /// Writes data to csv file (id, area, perimeter)
    /// </summary>
    /// <param name="list">List of shapes</param>
    public static void WriteData(List<Shape> list) {
        using (var w = new StreamWriter("output.csv")) {
            foreach (Shape s in list) {
                var first = s.GetId();
                var second = s.CalculateArea();
                var third = s.CalculatePerimeter();
                var line = string.Format("{0},{1},{2}", first, second, third);
                w.WriteLine(line);
                w.Flush();
            }
        }
    }

    /// <summary>
    /// Main method of program
    /// </summary>
    public static void Main() {
        List<Shape> list = ImportShapes();
        WriteData(list);
    }
}