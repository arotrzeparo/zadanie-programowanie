using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = 0;
            int y = 5 / x;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred.");
        }
        finally
        {
            Console.WriteLine("The try-catch block is complete.");
        }
    }
}

