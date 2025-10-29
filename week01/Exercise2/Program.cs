using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int mark = int.Parse(input);

        string grade = "";

        if (mark >= 90)
        {
            grade = "A";
        }

        else if (mark >= 80)
        {
            grade = "B";
        }

        else if (mark >= 70)
        {
            grade = "C";
        }

        else if (mark >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (mark >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Sorry! Next try time try harder!");
        }
    }
}