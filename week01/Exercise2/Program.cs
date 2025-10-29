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
        string sign = "";

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

        int lastDigit = mark % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {grade}{sign}");

        if (mark >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Sorry! Next try time try harder!");
        }

        if (grade == "A" && sign == "+")
        {
            sign = "";
        }

        else if (grade == "F")
        {
            sign = "";
        }
    }
}