using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual shapes
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Test the list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Green", 3, 6));
        shapes.Add(new Circle("Yellow", 2.5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape area: {shape.GetArea():F2}");
        }
    }
}