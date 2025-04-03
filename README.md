## About The Project
This project is a Geometry Computation Library designed to perform various geometric calculations and operations on 3D shapes. It provides functionality to create, manipulate, and analyze basic geometric shapes such as `Cuboids`, `Cylinders`, and `Tetrahedrons`, as well as composite shapes that combine multiple basic shapes.

## Getting Started 
### Prerequisites

Before running this project, ensure you have the following installed:
1. **.NET SDK (Version 8.0.406)**  
   - Download and install the .NET SDK from the official [.NET Download Page](https://dotnet.microsoft.com/download).

2. **A Code Editor (Optional)**  
   - Use an editor like [Visual Studio Code](https://code.visualstudio.com/) for editing and running the project.

3. **Terminal Access**  
   - Ensure you have access to a terminal or command prompt to run the necessary commands.
  
### Installation
1. Make sure you are using **8.0.406** version of .NET.
2. Open a new Terminal.
3. In the Terminal, you should type following commands: 
   
```bash
cd Computation
```
   and then:
```bash
dotnet run
```
   ### Output:
```bash
=== Testing Irregular Tetrahedron ===
Tetrahedron Surface Area: 25.00000000000001
Tetrahedron Centroid: (1.25, 0.75, 0.5)

=== Cuboid 1 ===
Cuboid Surface Area: 148
Cuboid Volume: 120
Cuboid Centroid: (2.5, 3, 2)

=== Testing Cylinder ===
Cylinder Surface Area: 117.80972450961724
Cylinder Volume: 98.17477042468104
Cylinder Height: GeometryLibrary.Edge
Cylinder Bottom Area: 19.634954084936208

=== Composite Shape ===
Composite Shape Surface Area: 290.80972450961724
Is Tetrahedron in Composite Shape: 2
Is Cuboid in Composite Shape: 0
Tetrahedron does not have a volume method.
Composite Shape Volume: 218.17477042468104
Access Cuboid from Composite Shape: GeometryLibrary.Tetrahedron

=== Sorted Composite Shape ===
Sort shapes based on their Surface Area: GeometryLibrary.Tetrahedron
Sort shapes based on their Surface Area: GeometryLibrary.Cylinder
Sort shapes based on their Surface Area: GeometryLibrary.Cuboid

Found Shape: GeometryLibrary.Cuboid
Found 2nd Shape: GeometryLibrary.Cuboid
```
### Usage
This project allows you to perform various geometric calculations and operations on 3D shapes. Below are some examples of how to use the library:

1. **Create Basic Shapes** <br>
   You can create shapes like `Cuboids`, `Cylinders`, and `Tetrahedrons` and calculate their properties:
```csharp
   // Create a Cuboid
   Vertex v1 = new Vertex(0, 0, 0);
   Vertex v2 = new Vertex(2, 0, 0);
   Vertex v3 = new Vertex(0, 3, 0);
   Vertex v4 = new Vertex(2, 3, 0);
   Vertex v5 = new Vertex(0, 0, 4);
   Vertex v6 = new Vertex(2, 0, 4);
   Vertex v7 = new Vertex(0, 3, 4);
   Vertex v8 = new Vertex(2, 3, 4);
   Cuboid cuboid = new Cuboid(v1, v2, v3, v4, v5, v6, v7, v8);

   Console.WriteLine($"Cuboid Surface Area: {cuboid.SurfaceArea()}");
   Console.WriteLine($"Cuboid Volume: {cuboid.Volume()}");
   Console.WriteLine($"Cuboid Centroid: {cuboid.Centroid()}");
```
2. **Combine Shapes into a Composite Shape** <br>
    Use the CompositeShape class to combine multiple shapes and calculate their combined properties:
```csharp
    // Composite Shape
    CompositeShape composite = new CompositeShape(3);
    composite += cuboid;
    composite += cylinder;
    composite += irregularTet;

    // Display the combined surface area
    Console.WriteLine($"Composite Shape Surface Area: {composite.SurfaceArea()}");
    Console.WriteLine($"Is Tetrahedron in Composite Shape: {composite.IsIn(irregularTet)}");
    Console.WriteLine($"Composite Shape Volume: {composite.Volume()}");
```

3. **Sort Shapes by Surface Area** <br>
    Sort the shapes in a CompositeShape by their surface area:
```csharp
    composite.SortShapesBySurfaceArea();
    foreach (var shape in composite)
    {
        Console.WriteLine($"Shape Surface Area: {shape)}");
    }
```
## Roadmap 

### Completed Features
- **Basic Shape Classes**: Implemented classes for `Cuboid`, `Cylinder`, and `Tetrahedron` with methods to calculate:
  - Surface Area
  - Volume
  - Centroid
- **Composite Shape**: Added functionality to combine multiple shapes into a composite shape and calculate:
  - Combined Surface Area
  - Combined Volume
- **Sorting**: Implemented sorting of shapes in a `CompositeShape` by surface area using the `IComparable` interface.
- **Custom Operators**: Overloaded operators for:
  - Adding shapes to a `CompositeShape` using the `+` operator.
  - Accessing shapes in a `CompositeShape` using the `[]` operator.
- **Search Functionality**: Added the `IsIn` method to check if a shape exists in a `CompositeShape` and return its index.

### Planned Features
- **Visualization**: Add a graphical interface to visualize shapes and their properties.
- **Unit Tests**: Add comprehensive unit tests to ensure the correctness of all calculations and methods.

## Contributing 
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make to this project are **greatly appreciated**.

If you would like to contribute, clone this repository to your local machine:
```bash
https://github.com/cc231008/3D-Geometric-Objects.git
```
## License 
No license is used.

## Contact
**Email:** cc231008@fhstp.ac.at

## Acknowledgments
- **Stack Overflow**: For helping troubleshoot and solve programming challenges.  
  [Visit Stack Overflow](https://stackoverflow.com/)
- **Microsoft .NET Documentation**: For providing detailed documentation and examples for .NET development.  
  [Visit .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
