using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    Console.Write("Enter number: ");
    List<int> numbers = new List<int>();
    int number = int.Parse(Console.ReadLine());

    while (number != 0)
    {
        numbers.Add(number);
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
    }

    float sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }
    float average = sum / numbers.Count;

    int largest = numbers[0];
    foreach (int i in numbers)
    {
        if (i > largest)
        {
            largest = i;
        }
    }

    Console.WriteLine("The sum is " + sum);
    Console.WriteLine("The average is " + average);
    Console.WriteLine("The largest number is " + largest);
    }
}