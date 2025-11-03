public class Job
{
    public string company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({company}) {_startYear}-{_endYear}");
    }
}