using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        int _count = 1;
        int num = 0;
        int den = 0;

        Fraction f5 = new Fraction();
        Random r1 = new Random();

        // FOR LOOP VERSION
        //  for (int i = 0; i < 20; i++)
        while(_count<=20)
        {
            num = r1.Next(1,999);
            f5.SetTop(num);

            den = r1.Next(1,999);
            f5.SetBottom(den);
        
            Console.WriteLine($"Fraction {_count}: string: {f5.GetFractionString()} Number: {f5.GetDecimalValue()}");     

            _count +=1;
        }


    }
}