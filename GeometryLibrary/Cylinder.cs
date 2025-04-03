namespace GeometryLibrary;


public class Cylinder : Shape
{
    // Fields
    public Vertex[] verteces { get; } = new Vertex[2];
    public double radius;

    // Constructor
    public Cylinder(Vertex v1, Vertex v2, double radius)
    {
        verteces[0] = v1;
        verteces[1] = v2;
        this.radius = radius;
    }

    public static bool operator ==(Cylinder c1, Cylinder c2)
    {
        if (ReferenceEquals(c1, c2)) return true;
        if (c1 is null || c2 is null) return false;

        // Check if the surface areas are equal
        return c1.SurfaceArea() == c2.SurfaceArea();
    }

    public static bool operator !=(Cylinder c1, Cylinder c2)
    {
        return !(c1 == c2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Cylinder other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(verteces, radius);
    }

    // Methods
    public Edge Height() 
    {
        // Calculate the height of the cylinder using the distance between the two vertices
        return new Edge(verteces[0], verteces[1]);
    }

    // Cylinder Bottom Area formula : Area = π * r^2
    public double BottomArea() 
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    // Cylinder Volume formula : Volume = π * r^2 * h
    public double Volume() 
    {
        return BottomArea() * Height().Length;
    }

    // Cylinder Surface Area formula : Surface Area = 2 * π * r * (r + h) OR 2 * π * r * h + 2 * π * r^2
    public override double SurfaceArea() 
    {
        return 2 * Math.PI * radius * (radius + Height().Length);
    }
}

    