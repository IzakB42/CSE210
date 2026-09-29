using System;

class Program
{
    // static int Sum(List<int> nums)
    // {
    //     for (int i=0; i++)
    //     return answer;
    // }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_number = 0;
        int Sum = 0;
        float entries = 0;
        float avg = 0;
        int max = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");

            new_number = int.Parse(Console.ReadLine());
            if(new_number != 0)
            {
                numbers.Add(new_number);
            }
        }while(new_number != 0);

        foreach(int num in numbers)
        {  
            entries +=1;
            Sum += num;
            if(num > max)
            {
                max = num;
            }
        }

        avg = ((float)Sum) / entries;
        // the float present in the equation allows us to get a float result with only integers in the equation.

        Console.WriteLine($"The sum is: {Sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}