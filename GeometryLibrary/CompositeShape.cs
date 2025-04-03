using System.Collections;

namespace GeometryLibrary;

public class CompositeShape : Shape, IEnumerable<Shape>
{
    // Fields
    private List<Shape> shapes = new List<Shape>();
    private int maxShapes;


    // Override [] operator
    public Shape this[int index]
    {
        get
        {
            if (index < 0 || index >= shapes.Count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            return shapes[index];
        }
        set
        {
            if (index < 0 || index >= shapes.Count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            shapes[index] = value;
        }
    }


    // Constructor
    public CompositeShape(int maxShapes)
    {
        this.maxShapes = maxShapes;
    }

    public int IsIn(Shape s)
    {
        // Check if the shape is in the composite shape 
        for (int i = 0; i < shapes.Count; i++)
        {
            if (shapes[i] == s)
            {
                return i;
            }
        }
        
        // If the shape is not found, return -1
        return - 1;

    }

    // Method to add a shape to the composite shape
    public void AddShape(Shape shape)
    {
        if (shapes.Count < maxShapes)
        {
            shapes.Add(shape);
        }
        else
        {
            Console.WriteLine("Cannot add more shapes to the composite shape.");
        }
    }

    public override double SurfaceArea()
    {
        double totalSurfaceArea = 0;
        foreach (var shape in shapes)
        {
            totalSurfaceArea += shape.SurfaceArea();
        }
        return totalSurfaceArea;
    }

    public double Volume() 
    {
        double totalVolume = 0;
        foreach (var shape in shapes)
        {
            if (shape is Cuboid cuboid)
            {
                totalVolume += cuboid.Volume();
            }
            else if (shape is Cylinder cylinder)
            {
                totalVolume += cylinder.Volume();
            }
            else if (shape is Tetrahedron tetrahedron)
            {
                Console.WriteLine("Tetrahedron does not have a volume method.");
            }
        }
        return totalVolume;
    }

    
    // Sort shapes by surface area
     // Sort shapes by surface area
    public void SortShapesBySurfaceArea()
    {
        shapes.Sort(); // Sorts shapes based on their SurfaceArea using IComparable
    }

    // Implement IEnumerable<Shape> to allow iteration
    public IEnumerator<Shape> GetEnumerator()
    {
        return shapes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
  
}