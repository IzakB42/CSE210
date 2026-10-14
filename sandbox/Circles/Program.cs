using System.Runtime.CompilerServices;

class Program
{
    
    static void Main()
    {
        Console.WriteLine("Hello Circle!");

        Circle myCircle = new Circle(42);


        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }

}