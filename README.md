# Geometric Shapes

A simple C# program that calculates the area and perimeter of geometric shapes: circle, rectangle, and triangle.

## Project Structure

The project consists of the following files:

- **`IFormeGeometriche.cs`**: Interface defining the `CalcArea()` and `CalcPerimetro()` methods.
- **`Cerchio.cs`**: Class for circles, implementing `IFormeGeometriche`.
- **`Rettangolo.cs`**: Class for rectangles, implementing `IFormeGeometriche`.
- **`Triangolo.cs`**: Class for triangles, implementing `IFormeGeometriche`.
- **`Program.cs`**: Main program file, allowing the user to choose a geometric shape and calculate its area and perimeter.

## Important Notes

- Variable names and printed messages are in **Italian**.
- The program expects user input in **Italian** (e.g., "inserisci la base" means "insert the base").
- The calculations and logic follow standard mathematical formulas.

## Requirements

- .NET SDK installed on your system.

## How to Run

To execute the program, open a terminal in the project folder and run:

```sh
dotnet run
