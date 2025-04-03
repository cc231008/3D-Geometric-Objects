using GeometryLibrary;
namespace Computation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Irregular Tetrahedron (known values)
        Console.WriteLine("=== Testing Irregular Tetrahedron ===");
        Vertex v5 = new Vertex(0, 0, 0);
        Vertex v6 = new Vertex(5, 0, 0);
        Vertex v7 = new Vertex(0, 3, 0);
        Vertex v8 = new Vertex(0, 0, 2);
        // Vertex v9 = new Vertex(0, 0, 0);
        // Vertex v10 = new Vertex(1, 0, 0);
        // Vertex v11 = new Vertex(0, 2, 0);
        // Vertex v12 = new Vertex(0, 0, 5);

        Tetrahedron irregularTet = new Tetrahedron(v5, v6, v7, v8);
        //Tetrahedron irregularTet2 = irregularTet;
        //Tetrahedron irregularTet3 = new Tetrahedron(v9, v10, v11, v12);

        Console.WriteLine($"Tetrahedron Surface Area: {irregularTet.SurfaceArea()}");
        Console.WriteLine($"Tetrahedron Centroid: {irregularTet.Centroid()}");

        //Console.WriteLine($"Tetrahedron 1 == Tetrahedron 2: {irregularTet == irregularTet2}");
        //Console.WriteLine($"Tetrahedron 1 == Tetrahedron 3: {irregularTet == irregularTet3}");

        Console.WriteLine();

         // First Cuboid (5x6x4)
        Vertex c1 = new Vertex(0, 0, 0);
        Vertex c2 = new Vertex(5, 0, 0);
        Vertex c3 = new Vertex(0, 6, 0);
        Vertex c4 = new Vertex(5, 6, 0);
        Vertex c5 = new Vertex(0, 0, 4);
        Vertex c6 = new Vertex(5, 0, 4);
        Vertex c7 = new Vertex(0, 6, 4);
        Vertex c8 = new Vertex(5, 6, 4);

        Cuboid cuboid1 = new Cuboid(c1, c2, c3, c4, c5, c6, c7, c8);
        //Cuboid cuboid2 = new Cuboid(c2, c1, c3, c4, c5, c6, c7, c8);

        // Display results
        Console.WriteLine("=== Cuboid 1 ===");
        Console.WriteLine($"Cuboid Surface Area: {cuboid1.SurfaceArea()}");
        Console.WriteLine($"Cuboid Volume: {cuboid1.Volume()}");
        Console.WriteLine($"Cuboid Centroid: {cuboid1.Centroid()}");

        Console.WriteLine();    

        // Cylinder (known values)
        Console.WriteLine("=== Testing Cylinder ===");
        Vertex v1 = new Vertex(0, 0, 0);
        Vertex v2 = new Vertex(0, 0, 5);
        double radius = 2.5;

        Cylinder cylinder = new Cylinder(v1, v2, radius);
        // Cylinder cylinder2 = new Cylinder(v1, v2, radius);
        // Cylinder cylinder3 = new Cylinder(v1, v2, 3.5);

        // Display results
        Console.WriteLine($"Cylinder Surface Area: {cylinder.SurfaceArea()}");
        Console.WriteLine($"Cylinder Volume: {cylinder.Volume()}");
        Console.WriteLine($"Cylinder Height: {cylinder.Height()}");
        Console.WriteLine($"Cylinder Bottom Area: {cylinder.BottomArea()}");

        // Console.WriteLine($"Cylinder == Cylinder 2: {cylinder == cylinder2}");
        // Console.WriteLine($"Cylinder == Cylinder 3: {cylinder == cylinder3}");

        // Composite Shape (known values)
        CompositeShape composite = new CompositeShape(3);
        composite += cuboid1;
        composite += cylinder;
        composite += irregularTet;

        Console.WriteLine();
        // Display the combined surface area
        Console.WriteLine("=== Composite Shape ===");
        Console.WriteLine($"Composite Shape Surface Area: {composite.SurfaceArea()}");
        Console.WriteLine($"Is Tetrahedron in Composite Shape: {composite.IsIn(irregularTet)}");
        Console.WriteLine($"Is Cuboid in Composite Shape: {composite.IsIn(cuboid1)}");
        Console.WriteLine($"Composite Shape Volume: {composite.Volume()}");

        Console.WriteLine($"Access Cuboid from Composite Shape: {composite[2]}");

        Console.WriteLine();
        // Sort the composite shapes based on their surface area
        composite.SortShapesBySurfaceArea();
        Console.WriteLine("=== Sorted Composite Shape ===");
        foreach (var shape in composite)
            {
                Console.WriteLine($"Sort shapes based on their Surface Area: {shape}");
            }
        
        Console.WriteLine();
        
        int cuboidIndex = composite.IsIn(cuboid1);
        if (cuboidIndex != -1) {
        // Access the cuboid from the composite shape using the index
        Shape foundShape = composite[cuboidIndex];
        Console.WriteLine($"Found Shape: {foundShape}");

        // Use copy constructor to create a new instance of the found shape
        Shape foundShape2 = foundShape;
        Console.WriteLine($"Found 2nd Shape: {foundShape2}");
        }
    }
}
