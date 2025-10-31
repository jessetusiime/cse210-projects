using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("  Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"  The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"  The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"  The largest number is: {max}");

        // smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("  No positive numbers were entered!");
        }
        else
        {
            Console.WriteLine($"  The smallest positive number is: {smallestPositive}");
        }

        // sort and print the list
        numbers.Sort();
        Console.WriteLine("  The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"  {number}");
        }
    }
}
