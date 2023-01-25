using System;

class Program
{
    // Method that takes an int parameter by value
    static void SquareByValue(int num)
    {
        num = num * num;
        Console.WriteLine("Inside SquareByValue method: {0}", num);
    }

    // Method that takes an int parameter by reference
    static void SquareByReference(ref int num)
    {
        num = num * num;
        Console.WriteLine("Inside SquareByReference method: {0}", num);
    }

    static void Main(string[] args)
    {
        int x = 5;
        int y = 10;

        Console.WriteLine("Before SquareByValue method: {0}", x);
        SquareByValue(x);
        Console.WriteLine("After SquareByValue method: {0}", x);

        Console.WriteLine("Before SquareByReference method: {0}", y);
        SquareByReference(ref y);
        Console.WriteLine("After SquareByReference method: {0}", y);

        Console.ReadKey();
    }
}
