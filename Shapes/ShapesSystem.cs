namespace Shapes
{
    using System;
    using Shapes.InnitialShapes;

    public class ShapesSystem
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[3]
            {
                new Rectangle(2, 1),
                new Square(2),
                new Triangle(2, 2)  
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"The area of the {shape.ToString().Split('.')[2]} is {shape.CalculateSurface():F2}");
            }
        }
    }
}
