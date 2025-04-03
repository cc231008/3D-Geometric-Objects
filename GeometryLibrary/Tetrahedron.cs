using System.ComponentModel;

namespace GeometryLibrary;

public class Tetrahedron : Shape
{
    // Fields
    public List<Vertex> vertices { get; } = new List<Vertex>();
    
    // Constructor
    public Tetrahedron(Vertex v1, Vertex v2, Vertex v3, Vertex v4)
    {
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        vertices.Add(v4);
    }

    public static bool operator ==(Tetrahedron t1, Tetrahedron t2)
    {
        if (ReferenceEquals(t1, t2)) return true;
        if (t1 is null || t2 is null) return false;
        
        return t1.SurfaceArea() == t2.SurfaceArea();

    }

    public static bool operator !=(Tetrahedron t1, Tetrahedron t2)
    {
        return !(t1 == t2);
    }
    public override bool Equals(object? obj)
    {
        if (obj is Tetrahedron other)
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
    public override double SurfaceArea() 
    {
        // Calculate the surface area of the irregular tetrahedron using the formula: Surface Area = A1 + A2 + A3 + A4
        double A1 = TriangleArea(vertices[0], vertices[1], vertices[2]); 
        double A2 = TriangleArea(vertices[0], vertices[1], vertices[3]);
        double A3 = TriangleArea(vertices[0], vertices[2], vertices[3]);
        double A4 = TriangleArea(vertices[1], vertices[2], vertices[3]); 

        // Comines the areas of the four triangular faces of the tetrahedron to get the total surface area.
        return A1 + A2 + A3 + A4; 
    }

    // Calculate the area of a triangle using Heron's formula: Area = √(s * (s - a) * (s - b) * (s - c))
    private double TriangleArea(Vertex v1, Vertex v2, Vertex v3)
    {
        // Calculate the lengths of the edges (or length) of the triangle
        Edge edge1 = new Edge(v1, v2);
        Edge edge2 = new Edge(v2, v3);
        Edge edge3 = new Edge(v3, v1);
        double a = edge1.Length;
        double b = edge2.Length;
        double c = edge3.Length;

        // Calculate the semi-perimeter with the formula:
        double s = (a + b + c) / 2;

        // Triangle Area = √(s * (s - a) * (s - b) * (s - c))
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
    }

    public Vertex Centroid()
    {
        // Calculate the centroid of the tetrahedron using the Average() method that calculates the average of the each vertex by iterating through the list of vertices.
        // (v => v.X) is a lambda expression that takes all verteces and returns their X coordinate.
        double x = vertices.Average(v => v.X);
        double y = vertices.Average(v => v.Y);
        double z = vertices.Average(v => v.Z);

        return new Vertex(x, y, z); 
    }
}