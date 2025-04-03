### Markdown Preview
To preview the Markdown file, press Ctrl + Shift + V (or Cmd + Shift + V on macOS).

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
## Contributing 
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make to this project are **greatly appreciated**.

## License 
No license is used.

## Contact
**Email:** cc231008@fhstp.ac.at

## Acknowledgments
- **Stack Overflow**: For helping troubleshoot and solve programming challenges.  
  [Visit Stack Overflow](https://stackoverflow.com/)
- **Microsoft .NET Documentation**: For providing detailed documentation and examples for .NET development.  
  [Visit .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)