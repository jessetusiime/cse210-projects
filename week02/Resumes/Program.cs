using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1.company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2.company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.display();
        job2.display();

        Resume myResume = new Resume();
        myResume._name = "Alison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.display();


    }
}