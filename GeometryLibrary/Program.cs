namespace GeometryLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Go to the Computation folder to run the tests.");
    }
}

// We are going to use IComparable interface to compare the shapes and sort them based on their volume. 
public abstract class Shape: IComparable<Shape>
{ 
    // This method calculates the surface area of the shape and returns it as a double or decimal number(e.g., 12.5).
    public abstract double SurfaceArea(); 

    // This method compares the volume of two shapes and returns an integer value.
    public int CompareTo(Shape? other)
    {
        if (other == null) return 1;
        return SurfaceArea().CompareTo(other?.SurfaceArea()); 
    }

    public static CompositeShape operator +(CompositeShape composite, Shape shape)
    {
        composite.AddShape(shape);
        return composite;
    }
}

// Vertex class represents a point in the shape.
public class Vertex
{
    // Fields
    // with get and set accessors, we can read and modify the values of these properties.
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Constructors
    public Vertex(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Overriding ToString method to show the verteces
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

// Edge class represents a line segment between two vertices.
public class Edge
{
    // Properties
    public Vertex Vertex1 { get; }
    public Vertex Vertex2 { get; }
    public double Length { get; }

    // Constructor
    public Edge(Vertex v1, Vertex v2)
    {
        Vertex1 = v1;
        Vertex2 = v2;
        Length = CalculateLength();
    }

    // Method to calculate the length of the edge using the distance formula: Length = √( (x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2 )
    private double CalculateLength()
    {
        double dx = Vertex2.X - Vertex1.X;
        double dy = Vertex2.Y - Vertex1.Y;
        double dz = Vertex2.Z - Vertex1.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

// Vecotr 
// We use struct instead because it is a value type and we want to avoid the overhead of reference types for small data structures.
public struct Vector
{
    // Fields and Properties
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Constructor
    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Cross product of two vectors formula: (V1 X V2) = (V1.Y * V2.Z - V1.Z * V2.Y, V1.Z * V2.X - V1.X * V2.Z, V1.X * V2.Y - V1.Y * V2.X)
    public static Vector Cross(Vector v1, Vector v2)
    {
        return new Vector(
            v1.Y * v2.Z - v1.Z * v2.Y,
            v1.Z * v2.X - v1.X * v2.Z,
            v1.X * v2.Y - v1.Y * v2.X
        );
    }
    // Dot product of two vectors formula: (V1 * V2) = (V1.X * V2.X) + (V1.Y * V2.Y) + (V1.Z * V2.Z)
    public static double Dot(Vector v1, Vector v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }
}


