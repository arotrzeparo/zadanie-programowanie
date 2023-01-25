using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a List of integers
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        // Adding an element to the list
        numbers.Add(6);

        // Removing an element from the list
        numbers.Remove(3);

        // Iterating through the list
        Console.WriteLine("List of numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Creating a Queue of strings
        Queue<string> names = new Queue<string>();

        // Adding elements to the queue
        names.Enqueue("John");
        names.Enqueue("Mary");
        names.Enqueue("Jane");

        // Removing an element from the queue
        names.Dequeue();

        // Iterating through the queue
        Console.WriteLine("\nQueue of names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Creating a Dictionary of key-value pairs
        Dictionary<string, int> scores = new Dictionary<string, int>();

        // Adding elements to the Dictionary
        scores.Add("John", 90);
        scores.Add("Mary", 80);
        scores.Add("Jane", 85);

        // Removing an element from the Dictionary
        scores.Remove("Mary");

        // Iterating through the Dictionary
        Console.WriteLine("\nDictionary of scores:");
        foreach (KeyValuePair<string, int> score in scores)
        {
            Console.WriteLine("{0} : {1}", score.Key, score.Value);
        }
    }
}
