using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square("bluish green", 2.5);
        // string square_color = sq1.GetColor();
        // Console.WriteLine(square_color);
        // Console.WriteLine(sq1.GetArea());

        Rectangle r1 = new Rectangle("yellow", 7, 6);
        // string rectangle_color = r1.GetColor();
        // Console.WriteLine(rectangle_color);
        // Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("purple", 5);
        // string circle_color = c1.GetColor();
        // Console.WriteLine(circle_color);
        // Console.WriteLine(c1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}