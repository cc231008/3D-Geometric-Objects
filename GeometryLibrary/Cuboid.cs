namespace GeometryLibrary;

public class Cuboid : Shape
{
    // Fields
    public List<Vertex> vertices { get; } = new List<Vertex>();

    // Constructor
    public Cuboid(Vertex v1, Vertex v2, Vertex v3, Vertex v4, Vertex v5, Vertex v6, Vertex v7, Vertex v8)
    {
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        vertices.Add(v4);
        vertices.Add(v5);
        vertices.Add(v6);
        vertices.Add(v7);
        vertices.Add(v8);
    }

    // Overriding the equality operator to compare two Cuboid objects
    public static bool operator ==(Cuboid c1, Cuboid c2)
    {
        if (ReferenceEquals(c1, c2)) return true;
        if (c1 is null || c2 is null) return false;

        // Check if the surface areas are equal
        return c1.SurfaceArea() == c2.SurfaceArea();
    }

    public static bool operator !=(Cuboid c1, Cuboid c2)
    {
        return !(c1 == c2);
    }
    public override bool Equals(object? obj)
    {
        if (obj is Cuboid other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(vertices);   
    }
        

    // Methods
    public Vertex Centroid()
    {
        double x = vertices.Average(v => v.X);
        double y = vertices.Average(v => v.Y);
        double z = vertices.Average(v => v.Z);

        return new Vertex(x, y, z);
    }

    // Formula for calculating volume of cuboid: Volume = length * width * height
    public double Volume() 
    {

        Edge length = new Edge(vertices[0], vertices[1]); // Along X-axis
        Edge width = new Edge(vertices[0], vertices[2]); // Along Y-axis
        Edge height = new Edge(vertices[0], vertices[4]); // Along Z-axis

        return length.Length * width.Length * height.Length;
    }

    // Formula for calculating surface area of cuboid: Surface Area = 2(lw + lh + wh)
    public override double SurfaceArea() 
    {
        Edge length = new Edge(vertices[0], vertices[1]); // Along X-axis
        Edge width = new Edge(vertices[0], vertices[2]); // Along Y-axis
        Edge height = new Edge(vertices[0], vertices[4]); // Along Z-axis

        return 2 * (length.Length * width.Length + length.Length * height.Length + width.Length * height.Length);
    }

}
